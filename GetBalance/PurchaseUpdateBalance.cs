using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Cosmos;
using GetBalance.Classes;
using System.Collections.Generic;

namespace GetBalance
{
    public static class PurchaseUpdateBalance
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("PurchaseUpdateBalance")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "patch", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;
            int price = data.price;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c WHERE c.userName = '{data.userName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<BalanceAccount> queryResult = container.GetItemQueryIterator<BalanceAccount>(queryDefinition);

            while (queryResult.HasMoreResults)
            {
                FeedResponse<BalanceAccount> currResult = await queryResult.ReadNextAsync();
                foreach (BalanceAccount item in currResult)
                {
                    if ((item.userBalance - price) >= 0)
                    {
                        int newBalance = item.userBalance - price;
                        List<PatchOperation> operation = new List<PatchOperation>
                        {
                            PatchOperation.Replace("/userBalance", newBalance)
                        };

                        ItemResponse<BalanceAccount> updateItem = await container.PatchItemAsync<BalanceAccount>($"{item.id}", new PartitionKey($"{item.userName}"), operation);
                        return new OkObjectResult($"User balance updated to: {item.userBalance - price}. \nItem updated for {updateItem.RequestCharge} R/Us");
                    }
                }
            }
            return new OkObjectResult("Insufficient funds, Please tweet more.");
        }
    }
}

