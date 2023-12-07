namespace Push.Dynamo.DomainModels.Twitter
{
    public class TwitterView
    {
        public string StreamName { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
        public string BroadcastId { get; set; }
        public string RequestedDateTime { get; set; }
        public string Views { get; set; }
    }
}
