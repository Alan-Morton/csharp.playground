﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Push.Analytics.API.Controllers
{
    public class TwitchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
