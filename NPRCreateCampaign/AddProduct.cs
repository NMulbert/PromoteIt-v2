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
using NPRCreateCampaign.Classes;
using System.Collections.Generic;

namespace NPRCreateCampaign
{
    public static class AddProduct
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("AddProduct")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "patch", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");



            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;
            string campaignName = data.campaignName;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            Product newProduct = ProductManager.CreateProduct(data);

            var sqlQuery = $"SELECT * FROM c WHERE c.campaignName = '{campaignName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Campaign> queryResult = container.GetItemQueryIterator<Campaign>(queryDefinition);

            List<PatchOperation> patchOperations = new List<PatchOperation>()
                                            {
                                                PatchOperation.Replace("/compName", newProduct.compName),
                                                PatchOperation.Replace("/product", newProduct.product),
                                                PatchOperation.Replace("/productCount", newProduct.productCount),
                                                PatchOperation.Replace("/price", newProduct.price)
                                            };

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Campaign> currResult = await queryResult.ReadNextAsync();
                foreach (Campaign camp in currResult)
                {
                    if (camp.campaignName == campaignName)
                    {
                        ItemResponse<Campaign> item = await container.PatchItemAsync<Campaign>($"{camp.id}", new PartitionKey($"{camp.campaignName}"), patchOperations);
                        return new OkObjectResult($"Item updated for {item.RequestCharge} R/Us");
                    }
                }
            }
            return new BadRequestObjectResult("Bad query");
        }
    }
}
