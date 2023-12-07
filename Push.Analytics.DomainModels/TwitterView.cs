namespace Push.Analytics.DomainModels
{
    public class TwitterView
    {
        public int TwitterPublicInsightsPk { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public string VideoId { get; set; }
        public int Views { get; set; }
        public int Concurrent { get; set; }
    }
}
