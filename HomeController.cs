using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shweta_core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace shweta_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private int shweta;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.name = "hello world";
            ViewBag.name1 = 2978;
            ViewBag.name2 = DateTime.Now;
            ViewBag.name3 = new List<string>()
            {
                "India",
                "USA",
                "Pak",

            };

            ViewData["demo"] = "View Data";
            ViewData["demo1"] = 88594;
            ViewData["demo2"]=DateTime.Now;
            ViewData["demo3"] = new List<string>()
            {
                "Apple",
                "Mango",
                "Banana"
            };

            TempData["Temp"] = "TempData";
            TempData["Temp1"] =94747;
            TempData["temp2"] = DateTime.Now;
            TempData["temp3"] = new List<string>()
            {
                "hi",
                "Hello",
                "Helo",
                "Hii"
            };

            HttpContext.Session.SetString("name", "Shweta");
           //var res=  HttpContext.Session.GetString("name"
            //var session = HttpContext

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
