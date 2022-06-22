using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Salary { get; set; }
    }
}