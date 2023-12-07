using System.Collections.Generic;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeAnalyticsResponse
    {
        public string GroupedBy { get; set; }
        public List<KeyValuePair<string, string>> YouTubeMeticsList { get; set; }
    }
}
