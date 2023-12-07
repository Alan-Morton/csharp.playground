using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookImpressions
    {
        public int FacebookImpressionsPk { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public int TotalVideoImpressions { get; set; }
        public int TotalVideoImpressionsUnique { get; set; }
        public int TotalVideoImpressionsPaidUunique { get; set; }
        public int TotalVideoImpressionsOrganicUnique { get; set; }
        public int TotalVideoImpressionsViralUnique { get; set; }
        public int TotalVideoImpressionsFanUnique { get; set; }
        public int TotalVideoImpressionsFanPaidUnique { get; set; }
    }
}
