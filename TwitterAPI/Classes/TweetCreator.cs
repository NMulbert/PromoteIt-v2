using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;

namespace TwitterAPI.Classes
{
    public class TweetCreator
    {
        public static Tweet CreateTweet(dynamic data)
        {
            Tweet newTweet = new Tweet();
            newTweet.tweetId = data.tweetId;
            newTweet.userName = data.userName;
            newTweet.hashTag = data.hashTag;
            newTweet.campaignLink = data.campaignLink;
            
            return newTweet;
        }
    }
}
