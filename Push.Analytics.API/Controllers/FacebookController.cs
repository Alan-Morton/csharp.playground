using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Push.DataAccess.Analytics;
using Push.Analytics.API.ViewModel;
using Push.Analytics.API.ViewModel.Enum;

namespace Push.Analytics.API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    [Produces("application/json")]
    public class FacebookController : ControllerBase
    {
        public FacebookReactionsData facebookReactionsData = new FacebookReactionsData();

        [HttpGet("{videoId}")]
        public JsonResult GetFacebookReactions([FromRoute] string videoId)
        {
            List<DomainModels.FacebookReactions> results = facebookReactionsData.GetFacebookReactionsList(videoId);
            return new JsonResult(results);
        }


        [HttpGet("{videoId}")]
        public JsonResult GetFacebookReactionsLatest([FromRoute] string videoId)
        {
            DomainModels.FacebookReactions results = facebookReactionsData.GetFacebookReaction(videoId);
            return new JsonResult(results);
        }

        [HttpGet("{projectId}")]
        public JsonResult GetDemographicGenderRatio([FromRoute] string projectId)
        {
            DemographicGenderRatio demographicGenderRatio = new DemographicGenderRatio();
            List<DemographicAgeRange> demographicAgeRanges = CreateDummyDemographicAgeRangeList();
            List<int> allFemales = demographicAgeRanges.Where(x => x.Gender == gender.female).Select(x => x.ViewTime).ToList();
            List<int> allMales = demographicAgeRanges.Where(x => x.Gender == gender.male).Select(x => x.ViewTime).ToList();
            List<int> allUni = demographicAgeRanges.Where(x => x.Gender == gender.uni).Select(x => x.ViewTime).ToList();
            demographicGenderRatio.FemaleViewTime = allFemales.Sum();
            demographicGenderRatio.MaleViewTime = allMales.Sum();
            demographicGenderRatio.UniViewTime = allUni.Sum();
            demographicGenderRatio.ViewTimeToal = allFemales.Sum() + allMales.Sum() + allUni.Sum();
            demographicGenderRatio.MalePercentage = Math.Round(Convert.ToDouble(demographicGenderRatio.MaleViewTime) / Convert.ToDouble(demographicGenderRatio.ViewTimeToal) * 100, 2);
            demographicGenderRatio.FemalePercentage = Math.Round(Convert.ToDouble(demographicGenderRatio.FemaleViewTime) / Convert.ToDouble(demographicGenderRatio.ViewTimeToal) * 100, 2);
            demographicGenderRatio.UniPercentage = Math.Round(Convert.ToDouble(demographicGenderRatio.UniViewTime) / Convert.ToDouble(demographicGenderRatio.ViewTimeToal) * 100, 2);
            return new JsonResult(demographicGenderRatio);
        }

        [HttpGet("{projectId}")]
        public JsonResult GetDemographicAgeRange([FromRoute] string projectId)
        {
            List<DemographicAgeRange> demographicAgeRanges = CreateDummyDemographicAgeRangeList();
            return new JsonResult(demographicAgeRanges);
        }

        [HttpGet("{projectId}")] // on load
        public JsonResult GetLiveViews()
        {
            return new JsonResult("");
        }


        [HttpGet("{projectId}")] // feed for recent results 
        public JsonResult GetLiveViewFeed()
        {
            return new JsonResult("");
        }

        [HttpGet("{projectId}")] // on load
        public JsonResult GetConcurrentViews()
        {
            return new JsonResult("");
        }


        [HttpGet("{projectId}")] // feed for recent results 
        public JsonResult GetConcurrentViewFeed()
        {
            return new JsonResult("");
        }

































        // dummy data helpers 
        private static List<DemographicAgeRange> CreateDummyDemographicAgeRangeList()
        {
            List<DemographicAgeRange> demographicAgeRanges = new List<DemographicAgeRange>();
            DemographicAgeRange demographicAgeRange = CreateDummyDemographicAgeRange("13-17", gender.female, 8228);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("13-17", gender.male, 112987);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("13-17", gender.uni, 0);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("18-24", gender.female, 61941);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("18-24", gender.male, 19651200);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("18-24", gender.uni, 61941);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("25-34", gender.female, 14522366);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("25-34", gender.male, 93590609);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("25-34", gender.uni, 672889);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("35-44", gender.female, 8613791);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("35-44", gender.male, 97149120);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("35-44", gender.uni, 1662213);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("45-54", gender.female, 11570960);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("45-54", gender.male, 31435152);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("45-54", gender.uni, 4063345);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("55-64", gender.female, 795715);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("55-64", gender.male, 7796216);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("55-64", gender.uni, 104650);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("65+", gender.female, 598811);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("65+", gender.male, 6419335);
            demographicAgeRanges.Add(demographicAgeRange);
            demographicAgeRange = CreateDummyDemographicAgeRange("65+", gender.uni, 935281);
            demographicAgeRanges.Add(demographicAgeRange);
            return demographicAgeRanges;
        }

        private static DemographicAgeRange CreateDummyDemographicAgeRange(string ageRange, gender gender, Int32 viewtime)
        {
            DemographicAgeRange demographicAgeRange = new DemographicAgeRange();
            demographicAgeRange.AgeRage = ageRange;
            demographicAgeRange.Gender = gender;
            demographicAgeRange.ViewTime = viewtime;
            return demographicAgeRange;
        }
    }
}
