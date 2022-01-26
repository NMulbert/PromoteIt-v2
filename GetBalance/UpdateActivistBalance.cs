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
    public static class UpdateActivistBalance
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("UpdateActivistBalance")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "patch", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;
            string userName = data.userName;
            int addedBalance = data.addedBalance;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c WHERE c.userName = '{userName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<BalanceAccount> queryResult = container.GetItemQueryIterator<BalanceAccount>(queryDefinition);

            List<PatchOperation> incrementOperation = new List<PatchOperation>()
                                            {
                                                PatchOperation.Increment("/userBalance", addedBalance),
                                            };

            while (queryResult.HasMoreResults)
            {
                FeedResponse<BalanceAccount> currResult = await queryResult.ReadNextAsync();
                foreach (BalanceAccount account in currResult)
                {
                    if (account.userName == userName)
                    {
                        ItemResponse<BalanceAccount> item = await container.PatchItemAsync<BalanceAccount>($"{account.id}", new PartitionKey($"{account.userName}"), incrementOperation);
                        return new OkObjectResult($"Balance updated by {addedBalance}$.");
                    }
                }
            }

            return new BadRequestObjectResult("User balance account does not exist.");
        }
    }
}
