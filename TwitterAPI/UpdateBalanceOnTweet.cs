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
using System.Net.Http;
using System.Collections.Generic;
using NPRCreateCampaign.Classes;
using TwitterAPI.Classes;
using Tweetinvi;

namespace TwitterAPI
{
    public static class UpdateBalanceOnTweet
    {
        private static string EndpointUri = "https://localhost:8081";
        private static string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        private static CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        private static Database database;
        private static Container container;

        static string consumerKey = "XOpxtgJlTexsYiRhjoeKc03Zl";
        static string consumerSecret = "k7evEa8DC7QktaGvU51wAeBOBFdPQxmh1Ko836X27lbbC0Hd5a";
        static string accessToken = "2264718769-2dyVQu2boG4CHLNWLNPAiIiRVEad4O62CALbax7";
        static string accessTokenSecret = "nTLN58C70ICurWOIXyIGXUa2h2CKKl6sSVNDzxr72g9v8";

        static TwitterClient client = new TwitterClient(consumerKey, consumerSecret, accessToken, accessTokenSecret);


        [FunctionName("UpdateBalanceOnTweet")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string dataBaseId = data.dataBaseId;
            string containerId = data.containerId;

            database = cosmosClient.GetDatabase(dataBaseId);

            HttpClient clientGetAllActivists = new HttpClient();
            string urlGetAllActivists = "http://localhost:7071/api/GetAllActivists";

            HttpClient clientGetCampaigns = new HttpClient();
            string urlGetCampaigns = "http://localhost:7730/api/GetCampaigns";


            string responseAllActivists = await clientGetAllActivists.GetStringAsync(urlGetAllActivists);
            
            List<string> activistsNames = JsonConvert.DeserializeObject<List<string>>(responseAllActivists);


            string responsGetCampaigns = await clientGetCampaigns.GetStringAsync(urlGetCampaigns);
            List<Campaign> campaigns = JsonConvert.DeserializeObject<List<Campaign>>(responsGetCampaigns);

            List<CampLinkCampHashTag> campLinkAndHashTag = new List<CampLinkCampHashTag>();

            foreach (var item in campaigns)
            {
                CampLinkCampHashTag camp = new CampLinkCampHashTag();
                camp.campaignlink = item.campaignLink;
                camp.campaignHashTag = item.campaignHashTag;
                campLinkAndHashTag.Add(camp);
            }

            foreach (var name in activistsNames)
            {
                int counter = 0;
                var userTimelineTweets = await client.Timelines.GetUserTimelineAsync($"{name}");
                
                foreach (var campaign in campLinkAndHashTag)
                {
                    foreach (var tweet in userTimelineTweets)
                    {
                        if (tweet.Text.Contains($"{campaign.campaignHashTag}") && tweet.Text.Contains($"{campaign.campaignlink}"))
                        {
                            //Tweet newTweet = TweetCreator.CreateTweet(tweet, name, campaign.campaignHashTag, campaign.campaignlink);
                            counter++;
                        }
                    }
                } 
                
            }
            return new OkObjectResult("11");
        }
    }
}
