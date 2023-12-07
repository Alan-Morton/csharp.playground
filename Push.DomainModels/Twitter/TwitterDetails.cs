namespace Push.Dynamo.DomainModels.Twitter
{
    public class TwitterDetails
    {
        public string EventId { get; set; }
        public string Title { get; set; }
        public string OutoutStreamKey { get; set; }
        public string BroadcastId { get; set; }
        public string UserId { get; set; }
        public string TweetId { get; set; }
        public int Status { get; set; }
    }
}
