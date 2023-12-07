namespace Push.Analytics.DomainModels
{
    public class TwitterStream
    {
        public int TwitterStreamPk { get; set; }
        public int DistributionId { get; set; }
        public string VideoId { get; set; }
        public int AccountId { get; set; }
        public string BroadcastId { get; set; }
        public string TweetId { get; set; }
    }
}
