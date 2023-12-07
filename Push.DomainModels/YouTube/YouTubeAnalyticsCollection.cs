using System.Collections.Generic;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeAnalyticsCollection
    {
        public YouTubeInfo YouTubeInfo { get; set; }
        public List<YouTubeAnalyticsResponse> YoutTubeAnalyticsResponses { get; set; }
    }
}
