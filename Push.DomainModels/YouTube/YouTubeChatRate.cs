using System;
using System.Collections.Generic;

namespace Push.Dynamo.DomainModels.YouTube
{
   public class YouTubeChatRate
    {
        public string LiveBroadcastId { get; set; }
        public DateTime RequestDate { get; set; }
        public string Date { get; set; }
        public YouTubeChatRateItem ChatRate { get; set; }        
        public List<YouTubeChatRateItem> YouTubeChatRateItems { get; set; }
    }
}
