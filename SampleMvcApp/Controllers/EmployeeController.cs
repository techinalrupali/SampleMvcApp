using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAllEmployee()
        {
            List<Employee> employeelist = new List<Employee>()
             {
               new Employee{Id=1,Name="Laxmi",Company="Infosys",Salary=45000},
               new Employee{Id=2,Name="Shweta",Company="IBM",Salary=50000},
               new Employee{Id=3,Name="Rajani",Company="HP",Salary=40000},
               new Employee{Id=4,Name="Shruti",Company="Sony",Salary=45000},
               new Employee{Id=5,Name="Tina",Company="Prorigo",Salary=45000},
             };
            ViewBag.EmployeeList =employeelist;
            return View();
        }
    }
}