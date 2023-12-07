using Amazon.DynamoDBv2.DataModel;

namespace Push.Dynamo.DomainModels.Facebook
{
    public class FacebookInfo
    {        
        [DynamoDBProperty("querytype")]
        public string QueryType { get; set; }
        [DynamoDBProperty("video-id")]
        public string VideoId { get; set; }        
        [DynamoDBProperty("page-id")]
        public string PageId { get; set; }
        [DynamoDBProperty("requesteddate")]
        public string RequestedDate { get; set; }
    }
}
