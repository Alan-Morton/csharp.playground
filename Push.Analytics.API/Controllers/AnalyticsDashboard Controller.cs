using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Push.Analytics.API.Controllers
{
    public class AnalyticsDashboardController : Controller
    {
        public JsonResult Index()
        {
            return new JsonResult("");
        }
    }
}
