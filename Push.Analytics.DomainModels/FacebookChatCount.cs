using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookChatCount
    {
        public int FacebookChatCountPk { get; set; }
        public string RequestDateTime { get; set; }
        public string VideoId { get; set; }
        public int Frequency { get; set; }
        public string DateInterval { get; set; }
        public int ChatCount { get; set; }
    }
}
