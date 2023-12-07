using System;

namespace Push.Dynamo.DomainModels.YouTube
{
    public class YouTubeLiveStreamingStatistics
    {        
        public Int64 ViewCount { get; set; }
        public Int64 LikeCount { get; set; }
        public Int64 DislikeCount { get; set; }
        public Int64 FavoriteCount { get; set; }
        public Int64 CommentCount { get; set; }
        public DateTime RequestDateTime { get; set; }
    }
}
