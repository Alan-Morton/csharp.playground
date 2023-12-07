namespace Push.Dynamo.DomainModels.YouTube
{
    public class DemographicAgeByGender
    {
        public string VideoId { get; set; }
        public string ChannelId { get; set; }
        public string RequestDateTime { get; set; }
        public string AgeRange { get; set; }
        public string MalePercentage { get; set; }
        public string FemalePercentage { get; set; }
    }
}
