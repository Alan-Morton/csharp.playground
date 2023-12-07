using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookReactions
    {
        public int FacebookReactionsId { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public int Sorry { get; set; }
        public int Haha { get; set; }
        public int Love { get; set; }
        public int Like { get; set; }
        public int Angry { get; set; }
        public int Wow { get; set; }
    }
}
