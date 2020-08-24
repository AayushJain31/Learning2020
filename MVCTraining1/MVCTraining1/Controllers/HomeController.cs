using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.Extensions.Logging;
using MVCTraining1.Models;
using PatientLibrary;

namespace MVCTraining1.Controllers
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger )//, IPatient P , IPatient P1)
        {
            
            _logger = logger;
        }

        //int i = 0;
        public IActionResult Index()
        {
            //byte[] y = null;

            //if(HttpContext.Session.TryGetValue("valueofi",out y))
            //{
            //    i = (int)HttpContext.Session.GetInt32("valueofi");
            //}
            //i++;
            //HttpContext.Session.SetInt32("valueofi", i);
            //TempData["Value"] = DateTime.Now.ToString();
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
