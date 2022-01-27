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

namespace GetBalance
{
    public static class GetBalance
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("GetBalance")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = "PromoteIt";
            string containerId = "Balance";

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            

            var sqlQuery = $"SELECT * FROM c WHERE c.userName = '{name}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<BalanceAccount> queryResult = container.GetItemQueryIterator<BalanceAccount>(queryDefinition);

            while (queryResult.HasMoreResults)
            {
                FeedResponse<BalanceAccount> response = await queryResult.ReadNextAsync();
                foreach (BalanceAccount item in response)
                {
                    if (item.userName == name)
                    {
                        return new OkObjectResult($"User Balance: {item.userBalance}");
                    }
                }
            }
            return new BadRequestObjectResult($"Could not find user name '{name}'.");
        }
    }
}
