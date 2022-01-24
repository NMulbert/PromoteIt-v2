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
using System.Collections.Generic;
using NPR_registration.Classes;

namespace NPR_registration
{
    public static class GetAllUseres
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;
        [FunctionName("GetAllUseres")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;
            string name= data.name;

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c";
            switch(containerId)
            {
                case "NPR":
                    {
                        QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                        FeedIterator<NPR> queryResult = container.GetItemQueryIterator<NPR>(queryDefinition);
                        List<NPR> partitionKeys = new List<NPR>();

                        while (queryResult.HasMoreResults)
                        {
                            FeedResponse<NPR> currResult = await queryResult.ReadNextAsync();
                            foreach (NPR item in currResult)
                            {
                                if (item.orgName.ToString()==name)
                                {
                                    return new OkObjectResult("Logged in");
                                }
                            }
                        }
                        
                    }
                    break;
                case "BCR":
                    {
                        QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                        FeedIterator<BCR> queryResult = container.GetItemQueryIterator<BCR>(queryDefinition);
                        List<BCR> partitionKeys = new List<BCR>();

                        while (queryResult.HasMoreResults)
                        {
                            FeedResponse<BCR> currResult = await queryResult.ReadNextAsync();
                            foreach (BCR item in currResult)
                            {
                                if (item.compName.ToString() == data.name)
                                {
                                    return new OkObjectResult("Logged in");
                                }
                            }
                        }

                    }
                    break;
                case "Activists":
                    {
                        QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                        FeedIterator<Activist> queryResult = container.GetItemQueryIterator<Activist>(queryDefinition);
                        List<Activist> partitionKeys = new List<Activist>();

                        while (queryResult.HasMoreResults)
                        {
                            FeedResponse<Activist> currResult = await queryResult.ReadNextAsync();
                            foreach (Activist item in currResult)
                            {
                                if (item.userName.ToString() == data.name)
                                {
                                    return new OkObjectResult("Logged in");
                                }
                            }
                        }

                    }
                    break;
            }
            return new BadRequestObjectResult("Please sign to the system");
                
        }
    }
}
