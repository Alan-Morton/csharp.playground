using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Push.Dynamo.DomainModels.Enum
{
    public enum TwitchQueryType
    {
        basic
    }

    public enum TwitterQueryType
    {
        basic,
        totalViews,
        concurrent
    }

    public enum YouTubeQueryType
    {
        Basic,
        Geographic,
        Demographic,
        Device,
        StreamStats,
        StreamDetails,
        ChatRate
    }

    public enum FacebookQueryType
    {
        Views,
        AllViewDetails,
        Impressions,
        Comments,
        Shares,
        DistributionShares,
        VideoReactions,
        Demographic,
        Geographic,
        StorieReactions,
        ChatRate,
        Time,
        RetentionGraphs,
        StreamDetails
    }
}
