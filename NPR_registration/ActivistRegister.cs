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
    public static class ActivistRegister
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("ActivistRegister")]
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

            await cosmosClient.GetDatabase($"{dataBaseId}")
            .DefineContainer(name: $"{containerId}", partitionKeyPath: "/userName")
            .WithUniqueKey()
            .Path("/userName")
            .Attach()
            .CreateIfNotExistsAsync();
            container = database.GetContainer(containerId);

            Activist newActivist = ActivistCreator.CreateActivist(data);

            try
            {
                ItemResponse<Activist> respons = await container.CreateItemAsync<Activist>(newActivist, new PartitionKey(newActivist.userName));

                return new OkObjectResult($"Item created for {respons.RequestCharge} R/Us");
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.Conflict)
            {
                return new OkObjectResult($"User name '{newActivist.userName}' already exists.");
            }

            
            
        }
    }
}
