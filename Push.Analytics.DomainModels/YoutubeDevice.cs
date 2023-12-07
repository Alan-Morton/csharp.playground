using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class YoutubeDevice
    {
        public int YoutubeDeviceOSPk { get; set; }
        public int YoutubeDevicePk { get; set; }
        public string RequestDateTime { get; set; }
        public string DataDateTime { get; set; }
        public int Frequency { get; set; }
        public string VideoId { get; set; }
        public deviceType deviceType { get; set; }
        public int Views { get; set; }
        public int EstimatedMinutesWatched { get; set; }
    }
}
