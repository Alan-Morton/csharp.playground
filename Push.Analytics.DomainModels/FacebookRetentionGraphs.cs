using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookRetentionGraphs
    {
        public int FacebookRetentionGraphsId { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public int Interval { get; set; }
        public int Views { get; set; }
    }
}
