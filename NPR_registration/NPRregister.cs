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
using System.Collections.Generic;

namespace NPR_registration
{
    public static class NPRregister
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;



        [FunctionName("NPRregister")]
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

            NPR newNPR = new NPR();
            newNPR.orgName = data.orgName;
            newNPR.email = data.email;
            newNPR.website = data.website;
            newNPR.password = data.password;

            var sqlQuery = $"SELECT c.orgName FROM c WHERE c.orgName = '{newNPR.orgName}'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<NPR> queryResult = container.GetItemQueryIterator<NPR>(queryDefinition);

            List<NPR> nprs = new List<NPR>();

            while (queryResult.HasMoreResults)
            {
                FeedResponse<NPR> currResult = await queryResult.ReadNextAsync();
                foreach (NPR item in currResult)
                {
                    nprs.Add(item);
                }               
            }

            if (nprs.Count > 0)
            {
                return new OkObjectResult("organization name already exists");
            }
            else
            {
                await container.CreateItemAsync<NPR>(newNPR, new PartitionKey(newNPR.orgName));

                return new OkObjectResult("item created");
            }
            
        }
    }
}
