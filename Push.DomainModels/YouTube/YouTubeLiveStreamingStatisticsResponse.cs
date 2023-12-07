using System;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeLiveStreamingStatisticsResponse
    {
        public DateTime RequestDateTime { get; set; }
        public YouTubeInfo YouTubeInfo { get; set; }
        public YouTubeLiveStreamingStatistics YouTubeLiveStreamingStatistics { get; set; }
    }
}
