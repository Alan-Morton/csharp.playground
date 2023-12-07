using System;
using System.Collections.Generic;
using System.Text;
using Push.Analytics.DomainModels.Enum;

namespace Push.Analytics.DomainModels
{
    public class FacebookDemographic
    {
        public int FacebookDemographicPk { get; set; }
        public string VideoId { get; set; }
        public string RequestDateTime { get; set; }
        public int Frequency { get; set; }
        public int Age13To17 { get; set; }
        public int Age18To24 { get; set; }
        public int Age25To34 { get; set; }
        public int Age35To44 { get; set; }
        public int Age45To54 { get; set; }
        public int Age55To64 { get; set; }
        public int Age65Plus { get; set; }
        public gender Gender { get; set; }
    }
}
