using System; 
using Push.Analytics.API.ViewModel.Enum;

namespace Push.Analytics.API.ViewModel
{
    public class DemographicAgeRange
    {
        public gender Gender { get;set; } 
        public string AgeRage { get; set; }
        public Int32 ViewTime { get; set; }
    }
}
