using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class YoutubeGeographic
    {
        public int YoutubeGeographicPk { get; set; }
        public string RequestdateTime { get; set; }
        public string DataDateTime { get; set; }
        public string VideoId { get; set; }
        public int Frequency { get; set; }
        public string GeoCode { get; set; }
        public string Country { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int Shares { get; set; }
        public int EstimatedMinutesWatched { get; set; }
        public int AverageViewDuration { get; set; }
        public double AverageViewPercentage { get; set; } 
        public int SubscribersGained { get; set; }
        public int SubscribersLost { get; set; }
    }
}
