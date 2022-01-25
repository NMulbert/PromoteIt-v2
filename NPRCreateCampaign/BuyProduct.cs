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

            HttpClient clientBalance = new HttpClient();
            string urlPurchaseUpdateBalance = "http://localhost:7734/api/PurchaseUpdateBalance";

            var userDataUpdateBalance = new
            {
                userName = data.userName,
                price = data.price,
                dataBaseId = "PromoteIt",
                containerId = "Balance"
            };

            HttpClient clientProduct = new HttpClient();
            string urlActivistUpdateProduct = "http://localhost:7071/api/ActivistUpdateProduct";

            var userDataUpdateProduct = new
            {
                userName = data.userName,
                product = data.product,
                dataBaseId = "PromoteIt",
                containerId = "Activists"
            };

            HttpClient clientOrder = new HttpClient();
            string urlCreateOrder = "http://localhost:7732/api/CreateOrders";

            var userDataCreateOrder = new
            {
                userName = data.userName,
                address = data.address,
                productName = data.product,
                price = data.price,
                compName = data.compName,
                dataBaseId = "PromoteIt",
                containerId = "Orders"
            };
            
            HttpClient clientTwitter = new HttpClient();
            string urlTweetOnPurchase = "http://localhost:7731/api/TweetOnPurchase";

            var userDataTwitter = new
            {
                userName = data.userName,         
                compName = data.compName,              
            };


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


            while (queryResult.HasMoreResults)
            {
                FeedResponse<Campaign> currResult = await queryResult.ReadNextAsync();
                foreach (Campaign item in currResult)
                {
                    await container.PatchItemAsync<Campaign>($"{item.id}", new PartitionKey($"{item.campaignName}"), DecreaseOperation);

                    HttpResponseMessage responseUpdateBalance = await clientBalance.PostAsJsonAsync(urlPurchaseUpdateBalance, userDataUpdateBalance);

                    if (responseUpdateBalance.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        await container.PatchItemAsync<Campaign>($"{item.id}", new PartitionKey($"{item.campaignName}"), IncreaseOperation);
                        return new OkObjectResult("Transaction failed due to insufficient funds.");
                    }
                }
            }

            await clientProduct.PostAsJsonAsync(urlActivistUpdateProduct, userDataUpdateProduct);

            await clientOrder.PostAsJsonAsync(urlCreateOrder,userDataCreateOrder);

            await clientTwitter.PostAsJsonAsync(urlTweetOnPurchase,userDataTwitter);

            return new OkObjectResult($"{data.userName} bought {data.product}");
        }
    }
}
