using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Push.Libraries.Common;
using Push.Libraries.Data;
using Push.Dynamo.DomainModels.YouTube;
using Push.Dynamo.DomainModels.Enum;

namespace Push.Data.Dynamo
{
    public class YouTubeData : AWSRepositoryReadOnly
    {
        public async Task<List<YouTubeAnalyticsCollection>> GetYoutTubeAnalyticsCollectionAsync(string videoId, string queryType)
        {
            string tableName = "analytics-youtube-data";
            List<YouTubeAnalyticsCollection> youTubeAnalyticsCollectionList = new List<YouTubeAnalyticsCollection>();
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("videoid", videoId);
                //parameters.AddExpression("videoid", "query_value_tuple", videoId, queryType);
            };
            Func<Task<List<Document>>, Task<List<YouTubeAnalyticsCollection>>> dataMapper = delegate (Task<List<Document>> reader)
            {
                foreach (Document r in reader.Result)
                {
                    YouTubeAnalyticsCollection youtTubeAnalyticsCollection = new YouTubeAnalyticsCollection();
                    YouTubeInfo youTubeInfo = new YouTubeInfo();
                    List<YouTubeAnalyticsResponse> youtTubeAnalyticsResponse = new List<YouTubeAnalyticsResponse>();
                    if (r.Keys.Count != 0)
                    {
                        foreach (string key in r.Keys)
                        {
                            if (key.ToLower() == "channelid")
                                youTubeInfo.ChannelId = r[key];
                            if (key.ToLower() == "videoid")
                                youTubeInfo.VideoId = r[key];
                            if (key.ToLower() == "querytype")
                                youTubeInfo.QueryType = r[key];
                            if (key.ToLower() == "requesteddate")
                                youTubeInfo.RequestedDate = r[key];
                            if (key.ToLower() == "youtubeanalyticsresponses")
                                youtTubeAnalyticsResponse = ExtendedSerializer.DeserializeJsonToObject<List<YouTubeAnalyticsResponse>>(r[key]); //List<YouTubeAnalyticsResponse>
                            youtTubeAnalyticsCollection.YoutTubeAnalyticsResponses = youtTubeAnalyticsResponse;
                            youtTubeAnalyticsCollection.YouTubeInfo = youTubeInfo;
                        }
                        youTubeAnalyticsCollectionList.Add(youtTubeAnalyticsCollection);
                    }
                }
                return Task.FromResult(youTubeAnalyticsCollectionList);
            };
            return await ExecuteExpressionDdbAsync(dataMapper, tableName, paramterMapper);
        }

        public List<YouTubeLiveStreamingStatisticsResponse> GetYouTubeLiveStreamingStatistics(string videoId, string queryType)
        {
            string tableName = "analytics-youtube-live";
            List<YouTubeLiveStreamingStatisticsResponse> youTubeLiveStreamingStatisticsResponseList = new List<YouTubeLiveStreamingStatisticsResponse>();
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddExpression("videoid", "query_value_tuple", videoId, queryType);
            };
            Func<List<Document>, List<YouTubeLiveStreamingStatisticsResponse>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    YouTubeLiveStreamingStatisticsResponse youTubeLiveStreamingStatisticsResponse = new YouTubeLiveStreamingStatisticsResponse();
                    YouTubeInfo youTubeInfo = new YouTubeInfo();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "channelid")
                            youTubeInfo.ChannelId = item[key];
                        if (key.ToLower() == "querytype")
                            youTubeInfo.QueryType = item[key];
                        if (key.ToLower() == "videoid")
                            youTubeInfo.VideoId = item[key];
                        if (key.ToLower() == "requesteddate")
                            youTubeLiveStreamingStatisticsResponse.RequestDateTime = Convert.ToDateTime(item[key]);
                        if (key.ToLower() == "youtubeanalyticsresponses")
                            youTubeLiveStreamingStatisticsResponse.YouTubeLiveStreamingStatistics = ExtendedSerializer.DeserializeJsonToObject<YouTubeLiveStreamingStatistics>(item[key]);
                    }
                    youTubeLiveStreamingStatisticsResponse.YouTubeInfo = youTubeInfo;
                    youTubeLiveStreamingStatisticsResponseList.Add(youTubeLiveStreamingStatisticsResponse);
                }
                return youTubeLiveStreamingStatisticsResponseList;
            };
            return ExecuteExpressionDdb(datamapper, tableName, paramterMapper);
        }

        public List<YouTubeliveStreamingDetailsResponse> GetYouTubeliveStreamingDetails(string videoId, string queryType)
        {
            string tableName = "analytics-youtube-live";
            List<YouTubeliveStreamingDetailsResponse> youTubeliveStreamingDetailsResponseList = new List<YouTubeliveStreamingDetailsResponse>();
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddExpression("videoid", "query_value_tuple", videoId, queryType);
            };
            Func<List<Document>, List<YouTubeliveStreamingDetailsResponse>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    YouTubeliveStreamingDetailsResponse youTubeliveStreamingDetailsResponse = new YouTubeliveStreamingDetailsResponse();
                    YouTubeInfo youTubeInfo = new YouTubeInfo();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "channelid")
                            youTubeInfo.ChannelId = item[key];
                        if (key.ToLower() == "querytype")
                            youTubeInfo.QueryType = item[key];
                        if (key.ToLower() == "videoid")
                            youTubeInfo.VideoId = item[key];
                        if (key.ToLower() == "requesteddate")
                            youTubeliveStreamingDetailsResponse.RequestDateTime = Convert.ToDateTime(item[key]);
                        if (key.ToLower() == "youtubeanalyticsresponses")
                            youTubeliveStreamingDetailsResponse.YouTubeliveStreamingDetails = ExtendedSerializer.DeserializeJsonToObject<YouTubeliveStreamingDetails>(item[key]);
                    }
                    youTubeliveStreamingDetailsResponse.YouTubeInfo = youTubeInfo;
                    youTubeliveStreamingDetailsResponseList.Add(youTubeliveStreamingDetailsResponse);
                }
                return youTubeliveStreamingDetailsResponseList;
            };
            return ExecuteExpressionDdb(datamapper, tableName, paramterMapper);
        }

        public List<YouTubeChatRate> GetYouTubeChatRate(string liveBroadcastId, YouTubeQueryType youTubeQueryType)
        {
            string tableName = "analytics-youtube-live";
            List<YouTubeChatRate> youTubeChatRatesList = new List<YouTubeChatRate>();
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddExpression("videoid", "query_value_tuple", liveBroadcastId, youTubeQueryType.ToString());
            };
            Func<List<Document>, List<YouTubeChatRate>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    List<YouTubeChatRateItem> YouTubeChatRateItemsList = new List<YouTubeChatRateItem>();
                    YouTubeChatRate youTubeChatRate = new YouTubeChatRate();
                    YouTubeChatRateItem youTubeChatRateItem = new YouTubeChatRateItem();
                    YouTubeInfo youTubeInfo = new YouTubeInfo();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "livebroadcastid")
                            youTubeChatRate.LiveBroadcastId = item[key];
                        if (key.ToLower() == "requesteddate")
                            youTubeChatRate.RequestDate = Convert.ToDateTime(item[key]);
                        if (key.ToLower() == "youtubeanalyticsresponses")
                            youTubeChatRate.ChatRate = ExtendedSerializer.DeserializeJsonToObject<YouTubeChatRateItem>(item[key]);
                    }
                    youTubeChatRatesList.Add(youTubeChatRate);
                };
                return youTubeChatRatesList;
            };
            return ExecuteExpressionDdb(datamapper, tableName, paramterMapper);
        }
    }
}
