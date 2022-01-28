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
using System.Collections.Generic;

namespace NPR_registration
{
    public static class GetAllUsersAdmin
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("GetAllUsersAdmin")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string containerId = req.Query["containerId"];
            string dataBaseId = "PromoteIt";

            database = cosmosClient.GetDatabase(dataBaseId);
            container = database.GetContainer(containerId);

            var sqlQuery = $"SELECT * FROM c";

            switch (containerId)
            {
                case "NPR":
                    {
                        QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                        FeedIterator<NPR> queryResult = container.GetItemQueryIterator<NPR>(queryDefinition);
                        List<NPR> listNPR = new List<NPR>();

                        while (queryResult.HasMoreResults)
                        {
                            FeedResponse<NPR> currResult = await queryResult.ReadNextAsync();
                            foreach (NPR item in currResult)
                            {
                                listNPR.Add(item);
                            }
                        }
                        return new OkObjectResult(listNPR);
                    }
                case "BCR":
                    {
                        QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                        FeedIterator<BCR> queryResult = container.GetItemQueryIterator<BCR>(queryDefinition);
                        List<BCR> listBCR = new List<BCR>();

                        while (queryResult.HasMoreResults)
                        {
                            FeedResponse<BCR> currResult = await queryResult.ReadNextAsync();
                            foreach (BCR item in currResult)
                            {
                                listBCR.Add(item);
                            }
                        }
                        return new OkObjectResult(listBCR);
                    }
                case "Activists":
                    {
                        QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
                        FeedIterator<Activist> queryResult = container.GetItemQueryIterator<Activist>(queryDefinition);
                        List<Activist> listActivists = new List<Activist>();

                        while (queryResult.HasMoreResults)
                        {
                            FeedResponse<Activist> currResult = await queryResult.ReadNextAsync();
                            foreach (Activist item in currResult)
                            {
                                listActivists.Add(item);
                            }
                        }
                        return new OkObjectResult(listActivists);
                    }
                    
            }
            return new BadRequestObjectResult("Unable to load data.");
        }
    }
}
