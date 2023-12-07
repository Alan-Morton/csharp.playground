using System.Collections.Generic;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeTop
    {
        public string ChannelId { get; set; }
        public List<int> Values { get; set; }
        public int Total { get; set; }
    }
}
