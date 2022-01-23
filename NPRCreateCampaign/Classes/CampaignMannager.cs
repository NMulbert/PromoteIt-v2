using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPRCreateCampaign.Classes
{
    public class CampaignMannager
    {
        public static Campaign CreateCampaign(dynamic data)
        {

            dynamic CampaignData = data;

            Campaign newCampaign = new Campaign();
            newCampaign.campaignName = CampaignData.campaignName;
            newCampaign.campaignLink = CampaignData.campaignLink;
            newCampaign.campaignHashTag = CampaignData.campaignHashTag;
            newCampaign.orgName = CampaignData.orgName;

            return newCampaign;
        }

        //public static async Task CreterContainer()
        //{
        //    await cosmosClient.GetDatabase($"{dataBaseId}")
        //       .DefineContainer(name: $"{containerId}", partitionKeyPath: $"/campaignName")
        //       .WithUniqueKey()
        //       .Path($"/{containerId}")
        //       .Attach()
        //       .CreateIfNotExistsAsync();
        //}
    }
}
