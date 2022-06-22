using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        [HttpGet]
        public ActionResult PersonalDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
  
            return View();
        }
        [HttpPost]
        public ActionResult PersonalDetails(FormCollection fc, ICollection<string>hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["Options"];
            return View("Details");
        }
        
    }
}