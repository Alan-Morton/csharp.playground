using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class YoutubeStream
    {
        public int YoutubeStreamPk { get; set; }
        public int DistributionId { get; set; }
        public int AccountId { get; set; }
        public string VideoId { get; set; }
        public string ChannelId { get; set; }
    }
}
