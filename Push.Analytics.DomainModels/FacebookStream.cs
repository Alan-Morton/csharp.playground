using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookStream
    {
        public int FacebookStreamId { get; set; }
        public int DistributionId { get; set; }
        public int AccountId { get; set; }
        public int VideoId { get; set; }
        public int PageId { get; set; }
    }
}
