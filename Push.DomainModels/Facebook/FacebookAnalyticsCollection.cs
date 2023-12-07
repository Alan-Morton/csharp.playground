using System;
using System.Collections.Generic;

namespace Push.Dynamo.DomainModels.Facebook
{
    public class FacebookAnalyticsCollection
    {
        public FacebookInfo FacebookInfo { get; set; }
        public List<InsightsValue> InsightsValues { get; set; }
    }
}
