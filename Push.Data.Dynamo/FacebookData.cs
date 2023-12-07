using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Push.Dynamo.DomainModels.Facebook;
using Amazon.DynamoDBv2.DocumentModel;
using Push.Libraries.Common;
using Push.Libraries.Data;
using Push.Dynamo.DomainModels.Enum;

namespace Push.Data.Dynamo
{
    public class FacebookData : AWSRepositoryReadOnly
    {
        public async Task<List<FacebookAnalyticsCollection>> GetFacebookAnalyticsCollectionListAsync(string videoId, string queryType)
        {
            string tableName = "analytics-facebook-live";
            List<FacebookAnalyticsCollection> facebookAnalyticsCollectionList = new List<FacebookAnalyticsCollection>();
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("videoid", videoId);
                //parameters.AddExpression("videoid", "query_value_tuple", videoId, queryType);
            };
            Func<Task<List<Document>>, Task<List<FacebookAnalyticsCollection>>> dataMapper = delegate (Task<List<Document>> reader)
            {
                foreach (Document item in reader.Result)
                {
                    FacebookAnalyticsCollection facebookAnalyticsCollection = new FacebookAnalyticsCollection();
                    FacebookInfo facebookInfo = new FacebookInfo();
                    List<InsightsValue> insightsValues = new List<InsightsValue>();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "videoid")
                            facebookInfo.VideoId = item[key];
                        if (key.ToLower() == "querytype")
                            facebookInfo.QueryType = item[key];
                        if (key.ToLower() == "requesteddate")
                            facebookInfo.RequestedDate = item[key];
                        if (key.ToLower() == "insightsvalues")
                            insightsValues = ExtendedSerializer.DeserializeJsonToObject<List<InsightsValue>>(item[key]);
                    }
                    facebookAnalyticsCollection.InsightsValues = insightsValues;
                    facebookAnalyticsCollection.FacebookInfo = facebookInfo;
                    facebookAnalyticsCollectionList.Add(facebookAnalyticsCollection);
                }
                return Task.FromResult(facebookAnalyticsCollectionList);
            };
            return await ExecuteExpressionDdbAsync(dataMapper, tableName, paramterMapper);
        }
        
        public async Task<List<FacebookLiveResponse>> GetFacebookLiveResponseAsync(string videoId, string queryType)
        {
            string tableName = "analytics-facebook-live";
            List<FacebookLiveResponse> facebookLiveResponseList = new List<FacebookLiveResponse>();
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                //parameters.AddExpression("videoid", "query_value_tuple", videoId, queryType);
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("videoid", videoId);
            };
            Func<Task<List<Document>>, Task<List<FacebookLiveResponse>>> dataMapper = delegate (Task<List<Document>> reader)
            {
                foreach (Document item in reader.Result)
                {
                    FacebookLiveResponse facebookLiveResponse = new FacebookLiveResponse();
                    FacebookLiveCommentItem facebookLiveCommentItem = new FacebookLiveCommentItem();
                    FacebookLiveResponseItem facebookLiveResponseItem = new FacebookLiveResponseItem();
                    FacebookInfo facebookInfo = new FacebookInfo();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "videoid")
                            facebookInfo.VideoId = item[key];
                        if (key.ToLower() == "querytype")
                            facebookInfo.QueryType = item[key];
                        if (key.ToLower() == "requesteddate")
                        {
                            DateTime dateTime = DateTime.ParseExact(item[key], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            facebookInfo.RequestedDate = dateTime.ToString();
                        }
                        if (key.ToLower() == "insightsvalues")
                        {
                            FacebookQueryType query = (FacebookQueryType)Enum.Parse(typeof(FacebookQueryType), queryType);
                            switch (query)
                            {
                                case FacebookQueryType.ChatRate:
                                    facebookLiveCommentItem = ExtendedSerializer.DeserializeJsonToObject<FacebookLiveCommentItem>(item[key]);
                                    facebookLiveResponse.FacebookLiveCommentItem = facebookLiveCommentItem;
                                    break;
                                case FacebookQueryType.StreamDetails:
                                    facebookLiveResponseItem = ExtendedSerializer.DeserializeJsonToObject<FacebookLiveResponseItem>(item[key]);
                                    facebookLiveResponse.FacebookLiveResponseItem = facebookLiveResponseItem;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    facebookLiveResponse.FacebookInfo = facebookInfo;
                    facebookLiveResponseList.Add(facebookLiveResponse);
                }
                return Task.FromResult(facebookLiveResponseList);
            };
            return await ExecuteExpressionDdbAsync(dataMapper, tableName, paramterMapper);
        }
    }
}
