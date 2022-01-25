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
using System.Net;

namespace OrderApp
{
    public static class CreateOrders
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("CreateOrders")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            string dataBaseId = data.dataBaseId;
            string containerId= data.containerId;
            database= cosmosClient.GetDatabase(dataBaseId);
            await cosmosClient.GetDatabase($"{dataBaseId}")
                .DefineContainer(name: $"{containerId}", partitionKeyPath: "/userName")
                .CreateIfNotExistsAsync();
            container = database.GetContainer(containerId);

            Order newOrder = OrderManager.CreateOrder(data);

            try
            {
                ItemResponse<Order> response = await container.CreateItemAsync<Order>(newOrder, new PartitionKey(newOrder.userName));
                return new OkObjectResult($"order created for {response.RequestCharge} R/Us");
            }
            catch(CosmosException ex) 
            {
                
                return new BadRequestObjectResult($"We are sorry the order didn't complete \nErroe{ex.Message}" );
            }

      

            
        }
    }
}
