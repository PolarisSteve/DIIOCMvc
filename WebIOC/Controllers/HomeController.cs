using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebIOC.Helpers;
using WebIOC.Models;

namespace WebIOC.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> _lg;
        IDisplayDateClass _ddc;

        public HomeController(ILogger<HomeController> lg, IDisplayDateClass ddc)
        {
            _lg = lg;
            _ddc = ddc;
        }

        public IActionResult Index()
        {

            _lg.LogInformation("Index");

            var ds = _ddc.ShowDateString;
            ViewBag.DateString = ds;


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            _lg.LogInformation("About");


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            _lg.LogInformation("Contact");


            return View();
        }

        public IActionResult Privacy()
        {
            _lg.LogInformation("Privacy");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
