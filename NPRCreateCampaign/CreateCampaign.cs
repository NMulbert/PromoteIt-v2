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
using System.Net;

namespace NPRCreateCampaign
{
    public static class CreateCampaign
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("CreateCampaign")]
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
            .DefineContainer(name: $"{containerId}", partitionKeyPath: $"/campaignName")
            .WithUniqueKey()
            .Path($"/{containerId}")
            .Attach()
            .CreateIfNotExistsAsync();
            container = database.GetContainer(containerId);




            Campaign newCampaign = CampaignMannager.CreateCampaign(data);
           

            //string sqlQuery = $"SELECT c.campaignName FROM c WHERE c.campaignName = '{newCampaign.campaignName}'";
            

            try
            {
                ItemResponse<Campaign> respons = await container.CreateItemAsync<Campaign>(newCampaign, new PartitionKey(newCampaign.campaignName));

                return new OkObjectResult($"Item created for {respons.RequestCharge} R/Us");
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.Conflict)
            {
                return new OkObjectResult($"Company name '{newCampaign.campaignName}' already exists.");
            }
        
            

            
        }
    }
}
