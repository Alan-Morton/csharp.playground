using System.Runtime.Serialization;

namespace Push.Dynamo.DomainModels.Facebook
{
    public class FacebookLiveResponseItem
    {        
        [DataMember(Name = "id")]
        public string Id { get; set; }
             
        [DataMember(Name = "broadcast_start_time")]
        public string BroadcastStartTime { get; set; }
                
        [DataMember(Name = "live_views")]
        public string LiveViews { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }
    }
}
