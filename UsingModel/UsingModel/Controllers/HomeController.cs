using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UsingModel.Models;

namespace UsingModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.AllCustomer = GetAllCustomer();
            ViewBag.AllProduct = GetAllProduct();
            return View();
        }

        public ActionResult ByViewModel()
        {
            ViewDataMordel data = new ViewDataMordel();
            data.customers = GetAllCustomer();
            data.products = GetAllProduct();

            return View(data);


        }

        public ActionResult ByViewData()
        {
            ViewData["AllCustomer"] = GetAllCustomer();
            ViewData["AllProduct"] = GetAllProduct();

            return View();

        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> listcustomer = new List<Customer>();
            listcustomer.Add(new Customer
            {
                CustomerID = "A001",
                FullName = "Kittipon",
                Address = "ASDweas"
            });
            listcustomer.Add(new Customer
            {
                CustomerID = "A002",
                FullName = "KITTIPOED",
                Address = "ASDweas"
            });
            listcustomer.Add(new Customer
            {
                CustomerID = "A003",
                FullName = "SLOOFL",
                Address = "ASDweas"
            });

            return listcustomer;
        }

        public List<Product> GetAllProduct()
        {
            List<Product> listproduct = new List<Product>();
            listproduct.Add(new Product
            {
                ProductID = "P01",
                ProductName = "ASP",
                ProductPrice = 2010
            });
            listproduct.Add(new Product
            {
                ProductID = "P02",
                ProductName = "C#",
                ProductPrice = 2100
            });
            listproduct.Add(new Product
            {
                ProductID = "P03",
                ProductName = "VB",
                ProductPrice = 2001
            });

            return listproduct;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
