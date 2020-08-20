using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientLibrary;

namespace MVCTraining1.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Add()
        {
            return View("PatientAdd");
        }
        public IActionResult MySubmit(Patient obj)
        {
            return View("PatientDisplay",obj);
        }
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
