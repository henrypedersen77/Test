﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace test.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //En kommentar

            return View();
        }
    }
}
