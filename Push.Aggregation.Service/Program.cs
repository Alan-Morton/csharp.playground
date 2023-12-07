using System;
using System.Collections.Generic;
using Push.Aggregation.Service.Helpers;
using Push.Analytics.DomainModels;
using Push.DataAccess.Analytics;

namespace Push.Aggregation.Service
{
    public class Program
    {
        private static YouTubeAggregationService youTubeAggregationService = new YouTubeAggregationService();

        static void Main(string[] args)
        {
            ///Aggregation needs to pick up new records every 5 / 10 mins and Aggregate them and dump them to dynamo / SQL table
            Console.WriteLine("Press 1 then return to Aggregation sim");
            Console.ForegroundColor = ConsoleColor.Blue;


            AggregationSimSeetings aggregationSimSeetings = new AggregationSimSeetings();
            aggregationSimSeetings.frequency = Analytics.DomainModels.Enum.frequency.fiveMinutes;
            aggregationSimSeetings.FakeYouTubeId = Guid.Parse("c2b5c607-8510-4209-9e0f-67176e8fb148");
            aggregationSimSeetings.EventId = 3;

            youTubeAggregationService.Start(aggregationSimSeetings);
        }
    }
}
