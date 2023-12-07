using System;

namespace Push.Dynamo.DomainModels.Twitch
{
    public class TwitchView
    {
        public string Date { get; set; }
        public int EventId { get; set; }
        public string ChannelName { get; set; }
        public int Views { get; set; }
        public DateTime RequestedDate { get; set; }
    }
}
