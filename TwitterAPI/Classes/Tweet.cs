using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterAPI.Classes
{
    public class Tweet
    {
        [JsonProperty(PropertyName = "id")]
        public string tweetId { get; set; }
        public string userName { get; set; }
        public string hashTag { get; set; }
        public string campaignLink { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
