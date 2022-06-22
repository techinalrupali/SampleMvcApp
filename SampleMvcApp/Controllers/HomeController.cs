﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] courses = { "C#", "Java", "MVC", "Angular" };
            ViewData["message"] = "This is my first mvc application";

            ViewBag.Courses = courses;
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}