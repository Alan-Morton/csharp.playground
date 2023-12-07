using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Push.Analytics.API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    [Produces("application/json")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public JsonResult Heartbeat()
        {
            TestRequestModel testRequestModel = new TestRequestModel();
            testRequestModel.Id = 1;
            testRequestModel.Title = "Heartbeat...";
            return new JsonResult(testRequestModel);
        }

        [HttpPost("{text}")]
        public async Task<JsonResult> Heartbeat([FromRoute] string text)
        {
            TestRequestModel testRequestModel = new TestRequestModel();
            testRequestModel.Id = 1;
            testRequestModel.Title = text;
            return new JsonResult(testRequestModel);
        }

        [HttpPost]
        public async Task<JsonResult> HeartbeatJson([FromBody] JObject text)
        {
            TestRequestModel testRequestModel = new TestRequestModel();
            testRequestModel.Id = 1;
            testRequestModel.Title = text.ToString();
            return await Task.FromResult(new JsonResult(testRequestModel));
        }
    }
    public class TestRequestModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
