﻿using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        
          public ActionResult SweetAlert()
        {
            return View();
        }
    }
}