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
        public static Tweet CreateTweet(ITweet tweet, string name, string hashtag,string link)
        {
            Tweet newTweet = new Tweet();
            newTweet.tweetId = tweet.Id;
            newTweet.userName = name;
            newTweet.hashTag = hashtag;
            newTweet.campaignLink = link;
            
            return newTweet;
        }
    }
}
