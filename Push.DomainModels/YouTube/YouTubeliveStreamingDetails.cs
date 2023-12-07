using System;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeliveStreamingDetails
    {
        public DateTime RequestDateTime { get; set; }                
        public DateTime StartTime { get; set; }        
        public DateTime EndTime { get; set; }                
        public DateTime ScheduledStartTime { get; set; }                
        public DateTime ScheduledEndTime { get; set; }                
        public Int64 ConcurrentViewers { get; set; }                
        public string ActiveLiveChatId { get; set; }
    }
}
