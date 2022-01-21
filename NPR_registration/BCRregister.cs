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
using System.Net;

namespace NPR_registration
{
    public static class BCRregister
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("BCRregister")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            BCR newBCR = BCRcreator.CreateBCR(data);


            // currently only catches if company name already exists in container (if the container has a unique key /compName).
            try
            {
                ItemResponse<BCR> respons = await container.CreateItemAsync<BCR>(newBCR, new PartitionKey(newBCR.compName));

                return new OkObjectResult($"Item created for {respons.RequestCharge} R/Us");
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.Conflict)
            {
                return new OkObjectResult($"Company name '{newBCR.compName}' already exists.");
            }
        }
    }
}
