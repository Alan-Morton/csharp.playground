
namespace Push.Analytics.DomainModels
{
    public class FacebookAllViewDetails
	{
        public int FacebookAllViewDetailsPk { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public int TotalVideoViews { get; set; }
        public int TotalVideoViewsUnique { get; set; }
        public int TotalVideoViewsAutoplayed { get; set; }
        public int TotalVideoViewsSoundOn { get; set; }
        public int TotalVideoViewsClickedToPlay { get; set; }
        public int TotalVideoViewsOrganic { get; set; }
        public int TotalVideoViewsOrganicUnique { get; set; }
        public int TotalVideoViewsPaid { get; set; }
        public int TotalVideoViewsPaidUnique { get; set; }
        public int TotalVideoCompleteViews { get; set; }
        public int TotalVideoCompleteViewsUnique { get; set; }
        public int TotalVideo10sViews { get; set; }
        public int TotalVideo10sViewsUnique { get; set; }
        public int TotalVideo10sViewsAutoPlayed { get; set; }
        public int TotalVideo10sViewsClickedToPlay { get; set; }
        public int TotalVideo10sViewsSoundOn { get; set; }
        public int TotalVideo10sViewsPaid { get; set; }
        public int TotalVideo10sViewsOrganic { get; set; }
    }
}
