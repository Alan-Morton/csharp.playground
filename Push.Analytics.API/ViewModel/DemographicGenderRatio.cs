using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Push.Analytics.API.ViewModel
{
    public class DemographicGenderRatio
    {
        public double MalePercentage { get; set; }
        public int MaleViewTime { get; set; }
        public double FemalePercentage { get; set; }
        public int FemaleViewTime { get; set; }
        public double UniPercentage { get; set; }
        public int UniViewTime { get; set; }
        public int ViewTimeToal { get; set; }
    }
}
