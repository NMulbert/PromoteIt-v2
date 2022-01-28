using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TimeTrigerUpadteTweetsAndBalance
{
    public class UpdateTweetsAndBalance
    {
        [FunctionName("UpdateTweetsAndBalance")]
        public async Task RunAsync([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
        {

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            HttpClient updateBalanceOnTweet = new HttpClient();
            string updateBalanceOnTweetUrl = "http://localhost:7731/api/UpdateBalanceOnTweet";
            HttpResponseMessage response = await updateBalanceOnTweet.GetAsync(updateBalanceOnTweetUrl);
            log.LogInformation(response.StatusCode.ToString());

        }
    }
}
