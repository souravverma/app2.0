using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app2._0.Models;
using Microsoft.Extensions.Configuration;

namespace app2._0.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;
        public HomeController(IConfiguration iConfig)
        {

            configuration = iConfig;
        }
        public IActionResult Index()
        {
            string dbConn2 = configuration.GetValue<string>("MySettings:DbConnection");
            string av = DbConnection;
            string ac = Environment.DbConnection;
            ViewBag.a = dbConn2;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
