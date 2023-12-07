using System;
using System.Collections.Generic;
using System.Text;
using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class YoutubeDeviceOS
    {
        public int YoutubeDeviceOSPk { get; set; }
        public int YoutubeDevicePk { get; set; }
        public string RequestDateTime { get; set; }
        public string DataDateTime { get; set; }
        public int Frequency { get; set; }
        public string VideoId { get; set; }
        public deviceExtendedType deviceExtendedType { get; set; }
        public int Views { get; set; }
        public int EstimatedMinutesWatched { get; set; }
    }
}
