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
using System.Text;
using System.Net;

namespace NPRCreateCampaign
{
    public static class GetCampaigns
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("GetCampaigns")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = "PromoteIt";//data.dataBaseId;
            string containerId = "Campaigns";//data.containerId;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = "SELECT * FROM c";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Campaign> queryResult = container.GetItemQueryIterator<Campaign>(queryDefinition);

            List<Campaign> campaigns = new List<Campaign>();

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Campaign> response = await queryResult.ReadNextAsync();
                foreach (var item in response)
                {
                    
                    campaigns.Add(item);
                }
            }

            return new OkObjectResult(JsonConvert.SerializeObject(campaigns));
        }
    }
}
