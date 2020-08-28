using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVCTraining1.Models;
using PatientLibrary;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace MVCTraining1.Controllers
{
    public class PatientController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admit()
        {
            return View("PatientAdmit");
        }
    }


}
