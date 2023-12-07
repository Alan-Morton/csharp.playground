using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class YoutubeLiveStats
    {
        public int? YoutubeliveStatsPk { get; set; }
        public System.DateTime RequestDateTime { get; set; }
        public frequency frequency { get; set; } 
        public string VideoId { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int Favorite { get; set; }
        public bool? isAggrigated { get; set; }
    }
}
