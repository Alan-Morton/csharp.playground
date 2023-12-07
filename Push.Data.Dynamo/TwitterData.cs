using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Push.Dynamo.DomainModels.Twitter;
using Amazon.DynamoDBv2.DocumentModel;
using Push.Libraries.Common;
using Push.Libraries.Data;

namespace Push.Data.Dynamo
{
    public class TwitterData : AWSRepositoryReadOnly
    {
        public List<TwitterPublicInsights> GetTwitterPublicInsightsViews(string id, string broadcasterId, string queryType)
        {
            string tableName = "analytics-twitter-broadcast";
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("id", id);
                //parameters.AddConditions("broadcasterid", broadcasterId);
            };
            List<TwitterPublicInsights> twwitterPublicInsightsList = new List<TwitterPublicInsights>();
            Func<List<Document>, List<TwitterPublicInsights>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    TwitterPublicInsights twwitterPublicInsights = new TwitterPublicInsights();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "id")
                            twwitterPublicInsights.Id = item[key];
                        if (key.ToLower() == "broadcasterid")
                            twwitterPublicInsights.BroadcastId = item[key];
                        if (key.ToLower() == "requesteddate")
                            twwitterPublicInsights.RequestedDateTime = item[key];
                        if (key.ToLower() == "insightmetrics")
                            twwitterPublicInsights.PublicMetric = ExtendedSerializer.DeserializeGraphApiPublicMetricsNET<PublicMetrics>(item[key]);
                    }
                    twwitterPublicInsightsList.Add(twwitterPublicInsights);
                };
                return twwitterPublicInsightsList;
            };
            return ExecuteProdDdb(datamapper, tableName, paramterMapper);
        }

        public List<TwitterView> GetTwitterViews(string id, string broadcasterid, string queryType)
        {
            string tableName = "analytics-twitter-broadcast";
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("id", id);
                //parameters.AddConditions("broadcasterid", broadcasterid);
            };
            List<TwitterView> twitterViewList = new List<TwitterView>();
            Func<List<Document>, List<TwitterView>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    TwitterView twitterView = new TwitterView();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "id")
                            twitterView.Id = item[key];
                        if (key.ToLower() == "broadcasterid")
                            twitterView.BroadcastId = item[key];
                        if (key.ToLower() == "requesteddate")
                            twitterView.RequestedDateTime = item[key];
                        if (key.ToLower() == "views")
                            twitterView.Views = item[key];
                    }
                    twitterViewList.Add(twitterView);
                };
                return twitterViewList;
            };
            return ExecuteProdDdb(datamapper, tableName, paramterMapper);
        }

        public List<TwitterView> GetTwitterConcurrentViews(string id, string broadcasterid, string queryType)
        {
            string tableName = "analytics-twitter-broadcast";
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("id", id);
                parameters.AddConditions("broadcasterid", broadcasterid);
            };
            List<TwitterView> twitterViewList = new List<TwitterView>();
            Func<List<Document>, List<TwitterView>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    TwitterView twitterView = new TwitterView();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "id")
                            twitterView.Id = item[key];
                        if (key.ToLower() == "broadcasterid")
                            twitterView.BroadcastId = item[key];
                        if (key.ToLower() == "requesteddate")
                            twitterView.RequestedDateTime = item[key];
                        if (key.ToLower() == "views")
                            twitterView.Views = item[key];
                    }
                    twitterViewList.Add(twitterView);
                };
                return twitterViewList;
            };
            return ExecuteProdDdb(datamapper, tableName, paramterMapper);
        }
    }
}
