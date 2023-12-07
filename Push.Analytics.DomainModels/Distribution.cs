using System;
using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class Distribution
    {
        public int DistributionPk { get; set; }
        public distributionType distributionType { get;set; }
        public int AccountId { get; set; }
    }
}
