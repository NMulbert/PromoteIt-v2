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
using OrderApp.Classes;
using System.Collections.Generic;

namespace OrderApp
{
    public static class GetOrders
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("GetOrders")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            string compName = req.Query["compName"];
            

            string dataBaseId = "PromoteIt";
            string containerId = "Orders";

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c WHERE c.compName='{compName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Order> queryResult = container.GetItemQueryIterator<Order>(queryDefinition);

            List<Order> orders = new List<Order>();

            while(queryResult.HasMoreResults)
            {
                FeedResponse<Order> currentOrder = await queryResult.ReadNextAsync();
                foreach(var item in currentOrder)
                {
                    orders.Add(item);
                }
            }

            return new OkObjectResult(orders);
        }
    }
}
