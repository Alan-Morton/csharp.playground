using System;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeliveStreamingDetailsResponse
    {
        public DateTime RequestDateTime { get; set; }
        public YouTubeInfo YouTubeInfo { get; set; }
        public YouTubeliveStreamingDetails YouTubeliveStreamingDetails { get; set; }
    }
}
