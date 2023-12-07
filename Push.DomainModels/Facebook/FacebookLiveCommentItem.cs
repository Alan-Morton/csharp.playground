using System.Runtime.Serialization;

namespace Push.Dynamo.DomainModels.Facebook
{
    public class FacebookLiveCommentItem
    {
        [DataMember(Name = "total_count")]
        public string CommentCount { get; set; }
    }
}
