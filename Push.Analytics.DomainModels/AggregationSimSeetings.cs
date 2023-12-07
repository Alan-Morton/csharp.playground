using System;
using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class AggregationSimSeetings
    {
        public int EventId { get; set; }
        public Guid FakeYouTubeId { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationInMinutes { get; set; }
        public frequency frequency { get; set; }
    }
}
