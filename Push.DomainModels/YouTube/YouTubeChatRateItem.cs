using System;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeChatRateItem
    {
        public string LiveBroadcastId { get; set; }
        public string LiveChatId { get; set; }
        public Int64 ChatCount { get; set; }
        public DateTime RequestDateTime { get; set; }
    }
}
