using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookStoryReactions
    {
        public int FacebookStoryReactionsId { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public int Share { get; set; }
    }
}
