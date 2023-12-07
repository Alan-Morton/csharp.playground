using System;

namespace Push.Analytics.DomainModels
{
    public class SimSeetings
    {
        public int EventId { get; set; }
        public Guid FakeYouTubeId { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationInMinutes { get; set; }
        public int FakePeakConcurrent { get; set; }
        public int EndViewsTotal { get; set; }
        public int TotalLikes { get; set; }
        public int TotalDislikes { get; set; }
        public int ChatRateTotal { get; set; }
        public int FakePeakCahtRate { get; set; }
    }
}
