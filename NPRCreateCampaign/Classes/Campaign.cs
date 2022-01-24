using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPRCreateCampaign.Classes
{
    public class Campaign
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; } = Guid.NewGuid();
        public string campaignName { get; set; }
        public string campaignLink { get; set; }
        public string campaignHashTag { get; set; }
        public string orgName { get; set; }
        public string compName { get; set; }
        public string product { get; set; }
        public int productCount { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
