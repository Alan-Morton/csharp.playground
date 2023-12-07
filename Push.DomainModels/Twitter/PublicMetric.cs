namespace Push.Dynamo.DomainModels.Twitter
{
    public class PublicMetrics
    {
        public bool? Attachemnts { get; set; }
        public string Id { get; set; }
        public Metric Metrics { get; set; }
        public string Text { get; set; }
    }
}
