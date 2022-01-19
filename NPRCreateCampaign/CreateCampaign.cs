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
            container = database.GetContainer(containerId);

            Campaign newCampaign = new Campaign();
            newCampaign.campaignName = data.campaignName;
            newCampaign.campaignLink = data.campaignLink;
            newCampaign.campaignHashTag = data.campaignHashTag;
            newCampaign.orgName = data.orgName;

            string sqlQuery = $"SELECT c.campaignName FROM c WHERE c.campaignName = '{newCampaign.campaignName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Campaign> queryResult = container.GetItemQueryIterator<Campaign>(queryDefinition);

            List<Campaign> campaigns = new List<Campaign>();

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Campaign> currResult = await queryResult.ReadNextAsync();
                foreach (Campaign item in currResult)
                {
                    campaigns.Add(item);
                }
            }
            if (campaigns.Count > 0)
            {
                return new BadRequestObjectResult("Campaign name already exists");
            }
            else
            {
                await container.CreateItemAsync<Campaign>(newCampaign, new PartitionKey(newCampaign.campaignName));

                return new OkObjectResult("Campaign created");
            }
            

            
        }
    }
}
