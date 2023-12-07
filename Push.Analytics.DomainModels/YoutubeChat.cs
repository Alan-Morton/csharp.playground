using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class YoutubeChat
    {
        public int YoutubeChatPk { get; set; }
        public string RequstDateTime { get; set; }
        public int Frequency { get; set; }
        public string VideoId { get; set; }
        public string LiveBroadcastId { get; set; }
        public string LiveChatId { get; set; }
        public int Count { get; set; }
    }
}
