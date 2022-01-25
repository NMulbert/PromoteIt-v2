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
using System.Net.Http;

namespace NPRCreateCampaign
{
    public static class BuyProduct
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;


        [FunctionName("BuyProduct")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "patch", Route = null)] HttpRequest req,
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

            var sqlQuery = $"SELECT * FROM c WHERE c.campaignName = '{campaignName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Campaign> queryResult = container.GetItemQueryIterator<Campaign>(queryDefinition);

            List<PatchOperation> DecreaseOperation = new List<PatchOperation>
                        {
                            PatchOperation.Increment("/productCount", -1)
                        };

            List<PatchOperation> IncreaseOperation = new List<PatchOperation>
                        {
                            PatchOperation.Increment("/productCount", 1)
                        };

            HttpClient client = new HttpClient();
            string url = "http://localhost:7734/api/PurchaseUpdateBalance";

            var userData = new
            {
                userName = data.userName,
                price = data.price,
                dataBaseId = "PromoteIt",
                containerId = "Balance"
            };

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Campaign> currResult = await queryResult.ReadNextAsync();
                foreach (Campaign item in currResult)
                {
                    await container.PatchItemAsync<Campaign>($"{item.id}", new PartitionKey($"{item.campaignName}"), DecreaseOperation);

                    HttpResponseMessage response = await client.PostAsJsonAsync(url, userData);

                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        await container.PatchItemAsync<Campaign>($"{item.id}", new PartitionKey($"{item.campaignName}"), IncreaseOperation);
                        return new OkObjectResult("Transaction failed due to insufficient funds.");
                    }
                }
            }
            return new OkObjectResult($"{data.userName} bought {data.product}");
        }
    }
}
