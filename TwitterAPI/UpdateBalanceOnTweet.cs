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

            HttpClient clientGetAllActivists = new HttpClient();
            string urlGetAllActivists = "http://localhost:7071/api/GetAllActivists";

            HttpClient clientGetCampaigns = new HttpClient();
            string urlGetCampaigns = "http://localhost:7730/api/GetCampaigns";

            HttpClient clientGetAllTweets = new HttpClient();
            string urlGetAllTweets = "http://localhost:7731/api/GetAllTweets";

            HttpClient clientAddTweet = new HttpClient();
            string urlAddTweet = "http://localhost:7731/api/AddTweet";

            HttpClient clientUpdateActivistBalance = new HttpClient();
            string urlUpdateActivistBalance = "http://localhost:7734/api/UpdateActivistBalance";


            string responseAllActivists = await clientGetAllActivists.GetStringAsync(urlGetAllActivists);
            List<string> activistsNames = JsonConvert.DeserializeObject<List<string>>(responseAllActivists);


            string responsGetCampaigns = await clientGetCampaigns.GetStringAsync(urlGetCampaigns);
            List<Campaign> campaigns = JsonConvert.DeserializeObject<List<Campaign>>(responsGetCampaigns);

            List<CampLinkCampHashTag> campLinkAndHashTag = new List<CampLinkCampHashTag>();


            string responseGetAllTweets = await clientGetAllTweets.GetStringAsync(urlGetAllTweets);
            List<Tweet> allTweets = JsonConvert.DeserializeObject<List<Tweet>>(responseGetAllTweets);

            List<string> tweetIdList = new List<string>();

            foreach (var item in allTweets)
            {
                tweetIdList.Add(item.tweetId);
            }

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
                        if (tweet.Text.Contains($"{campaign.campaignHashTag}"))
                        {
                            foreach (var item in tweet.Entities.Urls)
                            {
                                if (item.DisplayedURL.Contains($"{campaign.campaignlink}"))
                                {
                                    int i = 0;
                                    bool isBigger = true;
                                    while (isBigger && i < tweetIdList.Count)
                                    {
                                        if (tweet.Id <= long.Parse(tweetIdList[i]))
                                        {
                                            isBigger = false;
                                        }
                                        i++;
                                    }
                                    if (isBigger == true)
                                    {
                                        counter++;

                                        var validTweet = new
                                        {
                                            tweetId = tweet.Id.ToString(),
                                            userName = name,
                                            hashTag = campaign.campaignHashTag,
                                            campaignLink = campaign.campaignlink,
                                            retweetCount = tweet.RetweetCount,
                                            dataBaseId = "PromoteIt",
                                            containerId = "Tweets"
                                        };

                                        await clientAddTweet.PostAsJsonAsync(urlAddTweet, validTweet);
                                    }
                                }
                            }
                        }
                    }
                }
                if (counter > 0)
                {
                    var updatedBalance = new
                    {
                        userName = name,
                        addedBalance = counter,
                        dataBaseId = "PromoteIt",
                        containerId = "Balance"
                    };

                    await clientUpdateActivistBalance.PostAsJsonAsync(urlUpdateActivistBalance, updatedBalance);
                }
            }
            return new OkObjectResult("Checked all acitvists tweets.");
        }
    }
}
