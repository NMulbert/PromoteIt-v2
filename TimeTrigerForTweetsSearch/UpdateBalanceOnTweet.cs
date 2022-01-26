using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TimeTrigerForTweetsSearch
{
    public class UpdateBalanceOnTweet
    {
        [FunctionName("UpdateBalanceOnTweet")]
        public async Task Run([TimerTrigger("0 */2 * * * *")]TimerInfo myTimer, ILogger log)
        {
            HttpClient updateBalanceOnTweet = new HttpClient();
            string updateBalanceOnTweetUrl = "http://localhost:7731/api/UpdateBalanceOnTweet";
            HttpResponseMessage response  =await updateBalanceOnTweet.GetAsync(updateBalanceOnTweetUrl);

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            
        }
        
    }
}
