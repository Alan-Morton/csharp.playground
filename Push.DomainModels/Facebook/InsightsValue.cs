using System.Runtime.Serialization;

namespace Push.Dynamo.DomainModels.Facebook
{
    public class InsightsValue
    {        
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        [DataMember(Name = "value")]
        public double Value { get; set; }
    }
}
