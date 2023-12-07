using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class YoutubeConcurrent
    {
        public int YoutubeConcurrentPk { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public string VideoId { get; set; }
        public int Views { get; set; }
        public string LiveChatId { get; set; }
    }
}
