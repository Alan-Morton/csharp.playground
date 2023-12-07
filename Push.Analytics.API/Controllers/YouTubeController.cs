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
    public class YouTubeController : ControllerBase
    {
        public YouTubeLiveData youTubeLiveData = new YouTubeLiveData();

        [HttpGet("{videoId}/{frequency}")]
        public JsonResult GetLiveViews(string videoId, string frequency)
        {
            //"dd5fab17-41b5-4d59-9228-e11e9a8d27a5"

            List<DomainModels.YoutubeLiveStats> youTubeViewList = youTubeLiveData.GetYoutubeLiveStatsList(videoId, (DomainModels.Enum.frequency)Convert.ToInt32(frequency));
            return new JsonResult(youTubeViewList);
        }

        [HttpGet("{videoId}")]
        public JsonResult GetLiveConcurrentViews(string videoId)
        {
            List<YouTubeView> youTubeViewList = CreateFakeYouTubeConcurrentViews();
            return new JsonResult(youTubeViewList);
        }


        [HttpGet("{lastViewCount}")]        
        public JsonResult CreateOneNewFakeLiveView([FromRoute] int lastViewCount)
        {
            Random random = new Random();
            int view = random.Next(0, 1000000);
            view += Convert.ToInt32(lastViewCount);
            YouTubeView youTubeView = CreateYouTubeView(DateTime.Now, view);
            return new JsonResult(youTubeView);
        }

        [HttpGet]
        public JsonResult CreateOneNewFakeConcurrentView()
        {
            Random random = new Random();
            int view = random.Next(0, 1500000);            
            YouTubeView youTubeView = CreateYouTubeView(DateTime.Now, view);
            return new JsonResult(youTubeView);
        }

        private List<YouTubeView> CreateFakeYouTubeViews()
        {
            List<YouTubeView> youTubeViewList = new List<YouTubeView>();
            int interval = 2;
            Random random = new Random();
            int lastNumber = 0;
            for (int i = 0; i < interval; i++)
            {
                int view = random.Next(0, 1000000);
                view += lastNumber;
                lastNumber = view;
                YouTubeView youTubeView = CreateYouTubeView(DateTime.Now.AddMinutes(i), view);
                youTubeViewList.Add(youTubeView);
            }
            return youTubeViewList;
        }

        private List<YouTubeView> CreateFakeYouTubeConcurrentViews()
        {
            List<YouTubeView> youTubeViewList = new List<YouTubeView>();
            int interval = 2;
            Random random = new Random();
            int lastNumber = 0;
            for (int i = 0; i < interval; i++)
            {
                int view = random.Next(0, 1000000);
                lastNumber = view;
                YouTubeView youTubeView = CreateYouTubeView(DateTime.Now.AddMinutes(i), view);
                youTubeViewList.Add(youTubeView);
            }
            return youTubeViewList;
        }
        
        private YouTubeView CreateYouTubeView(DateTime dateTime, int views)
        {
            YouTubeView youTubeView = new YouTubeView();
            youTubeView.RequestTime = dateTime;
            youTubeView.Views = views;
            return youTubeView;
        }
    }
}
