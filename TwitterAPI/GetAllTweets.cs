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
using TwitterAPI.Classes;
using System.Collections.Generic;

namespace TwitterAPI
{
    public static class GetAllTweets
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        [FunctionName("GetAllTweets")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = "PromoteIt";
            string containerId = "Tweets";

            database = cosmosClient.GetDatabase(dataBaseId);
            await cosmosClient.GetDatabase($"{dataBaseId}")
            .DefineContainer(name: $"{containerId}", partitionKeyPath: $"/userName")
            .CreateIfNotExistsAsync();
            container = database.GetContainer(containerId);

            var sqlQuery = "SELECT * FROM c";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQuery);
            FeedIterator<Tweet> queryResult = container.GetItemQueryIterator<Tweet>(queryDefinition);

            List<Tweet> tweets = new List<Tweet>();

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Tweet> response = await queryResult.ReadNextAsync();
                foreach (Tweet item in response)
                {
                    tweets.Add(item);
                }
            }

            return new OkObjectResult(JsonConvert.SerializeObject(tweets));
        }
    }
}
