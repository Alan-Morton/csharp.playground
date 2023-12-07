using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Push.Dynamo.DomainModels.Twitch;
using Amazon.DynamoDBv2.DocumentModel;
using Push.Libraries.Common;
using Push.Libraries.Data;

namespace Push.Data.Dynamo
{
    public class TwitchData : AWSRepositoryReadOnly
    {
        public List<TwitchView> GetTwitchViews(string channelId, string eventId, string queryType)
        {
            string tableName = "analytics-twitch-live";
            Action<QueryOperationConfig> paramterMapper = delegate (QueryOperationConfig parameters)
            {
                parameters.AddConditions("channelid", channelId);
                parameters.AddBeginsWith("query_value_tuple", queryType);
                parameters.AddConditions("eventid", eventId);
            };
            List<TwitchView> twitchViewList = new List<TwitchView>();
            Func<List<Document>, List<TwitchView>> datamapper = delegate (List<Document> reader)
            {
                foreach (Document item in reader)
                {
                    TwitchView twitchView = new TwitchView();
                    foreach (string key in item.Keys)
                    {
                        if (key.ToLower() == "channelname")
                            twitchView.ChannelName = item[key];
                        if (key.ToLower() == "eventid")
                            twitchView.EventId = Convert.ToInt32(item[key]);
                        if (key.ToLower() == "views")
                            twitchView.Views = Convert.ToInt32(item[key]);
                        if (key.ToLower() == "requesteddate")
                            twitchView.RequestedDate = Convert.ToDateTime(item[key]);
                    }
                    twitchViewList.Add(twitchView);
                };
                return twitchViewList;
            };
            return ExecuteProdDdb(datamapper, tableName, paramterMapper);
        }
    }
}
