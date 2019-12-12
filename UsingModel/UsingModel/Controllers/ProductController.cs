using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingModel.Models;

namespace UsingModel.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var productlists = new List<Product>();
            productlists.Add(new Product { ProductID = "001", ProductName = "VB", ProductPrice = 2500 });
            productlists.Add(new Product { ProductID = "002", ProductName = "C#", ProductPrice = 2900 });
            productlists.Add(new Product { ProductID = "003", ProductName = "ASP", ProductPrice = 3500 });

            return View(productlists);
        }
    }
}