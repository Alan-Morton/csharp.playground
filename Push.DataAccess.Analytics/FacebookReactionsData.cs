using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Push.Libraries.Data;
using Push.Analytics.DomainModels;

namespace Push.DataAccess.Analytics
{
    public class FacebookReactionsData : ADORepository
    {
        public List<FacebookReactions> GetFacebookReactionsList(string videoId)
        {
            string sql = " SELECT facebook_reactions_pk,videoId,request_date_time,frequency,sorry,haha,love,[like],angry,wow " +
                         " FROM facebook_reactions WHERE videoId = @videoId";
            Action<SqlParameterCollection> mapper = delegate (SqlParameterCollection parameters)
            {
                parameters.AddParameter("videoId", videoId);
            };
            Func<SqlDataReader, List<FacebookReactions>> dataMapper = (SqlDataReader reader) =>
            {
                List<FacebookReactions> facebookReactionsList = new List<FacebookReactions>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FacebookReactions facebookReactions = new FacebookReactions();
                        if (reader["facebook_reactions_pk"] != DBNull.Value)
                            facebookReactions.FacebookReactionsId = Convert.ToInt32(reader["facebook_reactions_pk"]);
                        if (reader["videoId"] != DBNull.Value)
                            facebookReactions.VideoId = reader["videoId"].ToString();
                        if (reader["request_date_time"] != DBNull.Value)
                            facebookReactions.RequestDateTime = reader["request_date_time"].ToString();
                        if (reader["frequency"] != DBNull.Value)
                            facebookReactions.Frequency = Convert.ToInt32(reader["frequency"]);
                        if (reader["sorry"] != DBNull.Value)
                            facebookReactions.Sorry = Convert.ToInt32(reader["sorry"]);
                        if (reader["haha"] != DBNull.Value)
                            facebookReactions.Haha = Convert.ToInt32(reader["haha"]);
                        if (reader["love"] != DBNull.Value)
                            facebookReactions.Love = Convert.ToInt32(reader["love"]);
                        if (reader["like"] != DBNull.Value)
                            facebookReactions.Like = Convert.ToInt32(reader["like"]);
                        if (reader["angry"] != DBNull.Value)
                            facebookReactions.Angry = Convert.ToInt32(reader["angry"]);
                        if (reader["wow"] != DBNull.Value)
                            facebookReactions.Angry = Convert.ToInt32(reader["wow"]);
                        facebookReactionsList.Add(facebookReactions);
                    }
                }
                return facebookReactionsList;
            };
            return ExecuteSql(dataMapper, sql, mapper, true);

        }

        public FacebookReactions GetFacebookReaction(string videoId)
        {
            string sql = " SELECT TOP 1 facebook_reactions_pk,videoId,request_date_time,frequency,sorry,haha,love,[like],angry,wow " +
                        " FROM facebook_reactions WHERE videoId = @videoId " +
                        "ORDER BY facebook_reactions_pk DESC ";
            Action<SqlParameterCollection> mapper = delegate (SqlParameterCollection parameters)
            {
                parameters.AddParameter("videoId", videoId);
            };
            Func<SqlDataReader, FacebookReactions> dataMapper = (SqlDataReader reader) =>
            {
                FacebookReactions facebookReactions = new FacebookReactions();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["facebook_reactions_pk"] != DBNull.Value)
                            facebookReactions.FacebookReactionsId = Convert.ToInt32(reader["facebook_reactions_pk"]);
                        if (reader["videoId"] != DBNull.Value)
                            facebookReactions.VideoId = reader["videoId"].ToString();
                        if (reader["request_date_time"] != DBNull.Value)
                            facebookReactions.RequestDateTime = reader["request_date_time"].ToString();
                        if (reader["frequency"] != DBNull.Value)
                            facebookReactions.Frequency = Convert.ToInt32(reader["frequency"]);
                        if (reader["sorry"] != DBNull.Value)
                            facebookReactions.Sorry = Convert.ToInt32(reader["sorry"]);
                        if (reader["haha"] != DBNull.Value)
                            facebookReactions.Haha = Convert.ToInt32(reader["haha"]);
                        if (reader["love"] != DBNull.Value)
                            facebookReactions.Love = Convert.ToInt32(reader["love"]);
                        if (reader["like"] != DBNull.Value)
                            facebookReactions.Like = Convert.ToInt32(reader["like"]);
                        if (reader["angry"] != DBNull.Value)
                            facebookReactions.Angry = Convert.ToInt32(reader["angry"]);
                        if (reader["wow"] != DBNull.Value)
                            facebookReactions.Wow = Convert.ToInt32(reader["wow"]);
                    }
                }
                return facebookReactions;
            };
            return ExecuteSql(dataMapper, sql, mapper, true);
        }

        public void CreateFacebookReactions(FacebookReactions facebookReactions)
        {
            string sql = " INSERT INTO facebook_reactions (videoId, request_date_time, frequency, sorry, haha, love, [like], angry, wow)" +
                         " VALUES(@videoId, @request_date_time, @frequency, @sorry, @haha, @love, @like, @angry, @wow)";
            Action<SqlParameterCollection> parameterMapper = delegate (SqlParameterCollection parameters)
            {
                parameters.AddParameter("videoId", facebookReactions.VideoId);
                parameters.AddParameter("request_date_time", facebookReactions.RequestDateTime);
                parameters.AddParameter("frequency", facebookReactions.Frequency);
                parameters.AddParameter("sorry", facebookReactions.Sorry);
                parameters.AddParameter("haha", facebookReactions.Haha);
                parameters.AddParameter("love", facebookReactions.Love);
                parameters.AddParameter("like", facebookReactions.Like);
                parameters.AddParameter("angry", facebookReactions.Angry);
                parameters.AddParameter("wow", facebookReactions.Wow);
            };
            ExecuteNonQuery(sql, parameterMapper, true);
        }

        public void UpdateFacebookReactionsById(FacebookReactions facebookReactions)
        {
            string sql = "UPDATE facebook_reactions" +
                "SET " +
                "WHERE  ";
        }

        public void DeleteFacebookReactionsId(int facebookReactionsId)
        {
            string sql = "";
        }

        public void DeleteFacebookReactionsId(string videoId)
        {
            string sql = "";
        }
    }
}
