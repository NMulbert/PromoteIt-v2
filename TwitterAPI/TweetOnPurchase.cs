using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Tweetinvi;

namespace TwitterAPI
{
    public static class TweetOnPurchase
    {
        static string consumerKey = "XOpxtgJlTexsYiRhjoeKc03Zl";
        static string consumerSecret = "k7evEa8DC7QktaGvU51wAeBOBFdPQxmh1Ko836X27lbbC0Hd5a";
        static string accessToken = "2264718769-2dyVQu2boG4CHLNWLNPAiIiRVEad4O62CALbax7";
        static string accessTokenSecret = "nTLN58C70ICurWOIXyIGXUa2h2CKKl6sSVNDzxr72g9v8";

        static TwitterClient client = new TwitterClient(consumerKey, consumerSecret, accessToken, accessTokenSecret);

        [FunctionName("TweetOnPurchase")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string userName = data.userName;
            string compName = data.compName;

            var tweet = await client.Tweets.PublishTweetAsync($"@{userName}\n{compName}");

            return new OkObjectResult($"A new tweet created at: {tweet.CreatedAt.LocalDateTime} due to the user {userName} buying a product.");
        }
    }
}
