namespace Push.Dynamo.DomainModels.Twitter
{
    public class TwitterPublicInsights
    {
        public string StreamName { get; set; }
        public string Id { get; set; }
        public string BroadcastId { get; set; }
        public string RequestedDateTime { get; set; }
        public PublicMetrics PublicMetric { get; set; }
    }
}
