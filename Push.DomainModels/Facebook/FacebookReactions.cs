namespace Push.Dynamo.DomainModels.Facebook
{
    public class FacebookReactions
    {
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Like { get; set; }
        public int Love { get; set; }
        public int Wow { get; set; }
        public int HaHa { get; set; }
        public int Sorry { get; set; }
        public int Angry { get; set; }
    }
}
