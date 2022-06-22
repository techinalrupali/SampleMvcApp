using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcApp.Models;


namespace SampleMvcApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetAllProducts()
        {
            List<Product> productlist = new List<Product>()
             {
               new Product{Id=1,Name="Laptop",Company="HP",Price=45000},
               new Product{Id=2,Name="Laptop",Company="Dell",Price=50000},
               new Product{Id=3,Name="Laptop",Company="Lenovo",Price=40000},
               new Product{Id=4,Name="Keyboard",Company="HP",Price=45000},
               new Product{Id=5,Name="Mouse",Company="HP",Price=45000},
             };
            ViewBag.ProductList = productlist;
            return View();
        }
        public ActionResult ProductSave()
        {
            return View();
        }
    }
}