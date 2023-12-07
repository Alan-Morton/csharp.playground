namespace Push.Analytics.DomainModels
{
    public class TwitterPublicMetrics
    {
        public int TwitterPublicMetricsId { get; set; }
        public string RequestDateTime { get; set; }
        public string VideoId { get; set; }
        public int Frequency { get; set; }
        public int Like { get; set; }
        public int QuoteRetweets { get; set; }
        public int Retweets { get; set; }
        public int Replys { get; set; }
    }
}
