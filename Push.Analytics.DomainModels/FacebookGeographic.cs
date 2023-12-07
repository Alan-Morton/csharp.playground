using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Analytics.DomainModels
{
    public class FacebookGeographic
    {
        public int FacebookGeographicPk { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
