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
using System.Collections.Generic;
using OrderApp.Classes;

namespace OrderApp
{
    public static class UpdateStatus
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("UpdateStatus")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "patch","post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

 

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;
            string id = data.id;

            

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c WHERE c.id = '{data.id}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Order> queryResult = container.GetItemQueryIterator<Order>(queryDefinition);

            List<PatchOperation> patchOperations = new List<PatchOperation>()
                                            {
                                                PatchOperation.Replace("/shipped", "true"),
                                            };

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Order> currResult = await queryResult.ReadNextAsync();
                foreach (Order order in currResult)
                {
                    if (order.Id.ToString() == id&&order.shipped==false)
                    {
                        ItemResponse<Order> updateOrder = await container.PatchItemAsync<Order>($"{order.Id}", new PartitionKey($"{order.userName}"), patchOperations);
                        return new OkObjectResult($"Item updated for {updateOrder.RequestCharge} R/Us");
                    }
                }
            }
            return new BadRequestObjectResult("Badquery");
        }
    }
}
