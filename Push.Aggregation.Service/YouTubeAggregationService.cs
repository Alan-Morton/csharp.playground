using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Push.DataAccess.Analytics;
using Push.Analytics.DomainModels;
using Push.Analytics.DomainModels.Enum;
namespace Push.Aggregation.Service
{
    public class YouTubeAggregationService
    {
        public YouTubeLiveData youTubeLiveData = new YouTubeLiveData();

        public void Start(AggregationSimSeetings aggregationSimSeetings)
        {
            StartYoutubeLiveStatsAggregation(aggregationSimSeetings);
        }

        public void StartYoutubeLiveStatsAggregation(AggregationSimSeetings aggregationSimSeetings)
        {
            List<YoutubeLiveStats> youTubeViewList = youTubeLiveData.GetYoutubeLiveStatsList(aggregationSimSeetings.FakeYouTubeId.ToString(),frequency.oneMinute);
            aggregationSimSeetings.StartTime = youTubeViewList.FirstOrDefault().RequestDateTime;
            List<YoutubeLiveStats> youTubeViewListAgggateToFiveMinutes = youTubeViewList.GroupBy(x =>
            {
                DateTime stamp = x.RequestDateTime;
                stamp = stamp.AddMinutes(-(stamp.Minute % 60));
                stamp = stamp.AddMilliseconds(-stamp.Millisecond - 1000 * stamp.Second);
                return stamp;
            }).Select(g => new YoutubeLiveStats {
                RequestDateTime = g.Key
                , Views = (int)g.Average(s => s.Views)
                , isAggrigated = true
                , VideoId = aggregationSimSeetings.FakeYouTubeId.ToString()
                , frequency = frequency.fiveMinutes
                , Dislikes = 0
                , Favorite = 0
                , Likes = 0
            }).ToList();

            for (int i = 0; i < youTubeViewListAgggateToFiveMinutes.Count; i++)                            
                youTubeLiveData.CreateYoutubeLiveStatsResult(youTubeViewListAgggateToFiveMinutes[i]);
            

        }
    }
}
