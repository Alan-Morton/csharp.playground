using System;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeInfo
    {
        public string ChatId { get; set; }
        public string LiveBroadcastId { get; set; }
        public string ChannelId { get; set; }
        public string VideoId { get; set; }
        public string RequestedDate { get; set; }
        public DateTime RequestedDateAs_Datetime { get; set; }
        public string QueryType { get; set; }        
        public string RefreshToken { get; set; }
    }
}
