using System;
using System.Collections.Generic;
using System.Text;
using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class YoutubeDemographic
    {
        public int YoutubeDemographicPk { get; set; }
        public string RequestDateTime { get; set; }
        public string DataDateTime { get; set; }
        public int Frequency { get; set; }
        public string VideoId { get; set; } 
        public gender gender { get; set; }
        public string AgeRange { get; set; }
        public float ViewerPercentage { get; set; }
    }
}
