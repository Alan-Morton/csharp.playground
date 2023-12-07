using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Push.Libraries.Data;
using Push.Analytics.DomainModels;
using Push.Analytics.DomainModels.Enum;

namespace Push.DataAccess.Analytics
{
    public class YouTubeLiveData : ADORepository
    {
        public void CreateYoutubeLiveStatsResult(YoutubeLiveStats youtubeLiveStats)
        {
            string sql = " INSERT INTO youtube_live_stats (video_id, request_date_time, frequency, views, likes, dislikes, favorite, isAggrigated)" +
                        " VALUES(@video_id, @request_date_time, @frequency, @views, @likes, @dislikes, @favorite, @isAggrigated)";
            Action<SqlParameterCollection> parameterMapper = delegate (SqlParameterCollection parameters)
            {                
                parameters.AddParameter("request_date_time", youtubeLiveStats.RequestDateTime.ToString());
                parameters.AddParameter("frequency", youtubeLiveStats.frequency);
                parameters.AddParameter("video_id", youtubeLiveStats.VideoId);
                parameters.AddParameter("views", youtubeLiveStats.Views);
                parameters.AddParameter("likes", youtubeLiveStats.Likes);
                parameters.AddParameter("dislikes", youtubeLiveStats.Dislikes);
                parameters.AddParameter("favorite", youtubeLiveStats.Favorite);
                parameters.AddParameter("isAggrigated", youtubeLiveStats.isAggrigated);

            };
            ExecuteNonQuery(sql, parameterMapper, true);
        }

        public List<YoutubeLiveStats> GetYoutubeLiveStatsList(string videoId, frequency frequency)
        {
            string sql = "SELECT * FROM youtube_live_stats " +
                " WHERE video_id = @videoId AND frequency = @frequency " +
                " ORDER BY video_id DESC ";
            Action<SqlParameterCollection> mapper = delegate (SqlParameterCollection parameters)
            {
                parameters.AddParameter("videoId", videoId);
                parameters.AddParameter("frequency", frequency);
            };
            Func<SqlDataReader, List<YoutubeLiveStats>> dataMapper = (SqlDataReader reader) =>
            {
                List<YoutubeLiveStats> youtubeLiveStatsList = new List<YoutubeLiveStats>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        YoutubeLiveStats youtubeLiveStats = new YoutubeLiveStats();
                        youtubeLiveStats.YoutubeliveStatsPk = Convert.ToInt32(reader["youtube_live_stats_pk"]);
                        youtubeLiveStats.VideoId = videoId;
                        youtubeLiveStats.RequestDateTime = Convert.ToDateTime(reader["request_date_time"]);
                        youtubeLiveStats.frequency = (frequency)Convert.ToInt32(reader["frequency"]);
                        youtubeLiveStats.Views = Convert.ToInt32(reader["views"]);
                        youtubeLiveStatsList.Add(youtubeLiveStats);
                    }
                }
                return youtubeLiveStatsList;
            };
            return ExecuteSql(dataMapper, sql, mapper, true);
        }

        public YoutubeLiveStats GetYoutubeLiveStats(string videoId)
        {
            string sql = "SELECT TOP (1) * FROM youtube_live_stats ORDER BY video_id DESC ";
            Action<SqlParameterCollection> mapper = delegate (SqlParameterCollection parameters)
            {
                parameters.AddParameter("videoId", videoId);
            };
            Func<SqlDataReader, YoutubeLiveStats> dataMapper = (SqlDataReader reader) =>
            {
                YoutubeLiveStats youtubeLiveStats = new YoutubeLiveStats();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        youtubeLiveStats.YoutubeliveStatsPk = Convert.ToInt32(reader["youtube_live_stats_pk"]);
                        youtubeLiveStats.VideoId = videoId;
                        youtubeLiveStats.RequestDateTime = Convert.ToDateTime(reader["request_date_time"]);
                        youtubeLiveStats.frequency = (Push.Analytics.DomainModels.Enum.frequency)Convert.ToInt32(reader["frequency"]);
                        youtubeLiveStats.Views = Convert.ToInt32(reader["views"]);
                    }
                }
                return youtubeLiveStats;
            };
            return ExecuteSql(dataMapper, sql, mapper, true);
        }
    }
}
