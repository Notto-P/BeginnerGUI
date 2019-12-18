using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(DateTime setdate)
        {
            setdate = DateTime.Now;
            string daymonth = setdate.Month.ToString();
            DateTime dateTime = DateTime.Now;
            string setday = setdate.Year.ToString()+"-01-01";
            //string setyear = ""
            if (daymonth == "12")  
            {

                dateTime = DateTime.Now.AddMonths(1);
                dateTime.ToString("yyyy-MM-dd", new CultureInfo("en-US"));
                setday = dateTime.Year.ToString()+"-01-01";

            }
            ViewData["SetMonth"] = setday;
            ViewData["Setdaytime"] = setday;
            return View();

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
