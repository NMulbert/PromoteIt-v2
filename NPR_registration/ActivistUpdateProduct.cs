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
using NPR_registration.Classes;
using System.Collections.Generic;
using System.Net.Http;

namespace NPR_registration
{
    public static class ActivistUpdateProduct
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("ActivistUpdateProduct")]
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
            string product = data.product;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c WHERE c.userName = '{userName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Activist> queryResult = container.GetItemQueryIterator<Activist>(queryDefinition);

            List<PatchOperation> addProduct = new List<PatchOperation>
                        {
                            PatchOperation.Add("/products/-", product)
                        };

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Activist> currResult = await queryResult.ReadNextAsync();
                foreach (Activist item in currResult)
                {
                    await container.PatchItemAsync<Activist>($"{item.id}", new PartitionKey($"{item.userName}"), addProduct);
                }
            }


            return new OkObjectResult("11");
        }
    }
}
