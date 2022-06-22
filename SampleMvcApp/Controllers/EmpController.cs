using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        [HttpGet]
        public ActionResult EmpDetails() 
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);

            return View();
         
        }
        [HttpPost]
        public ActionResult EmpDetails(FormCollection fc, ICollection<string> technology) 
        {
            ViewBag.EmpId = fc["empId"];
            ViewBag.EmpName = fc["empname"];
            ViewBag.Empphone = fc["empphone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.Technology = technology;
            ViewBag.options = fc["Options"];
            return View("DetailsEmp");
        }
    }
}