using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTraining1.Models;
using PatientLibrary;

namespace MVCTraining1.Controllers
{
    public class PatientController : Controller
    {
        //static Stack<Patient> PatientList = new Stack<Patient>();
        //static List<PatientProblems> CurrentPatientProblem = new List<PatientProblems>();
        //static List<Treatment> PatientTreatment = new List<Treatment>();

        static PatientAdmitViewModel patientAdmitViewModel = new PatientAdmitViewModel();

        public PatientController()
        {
            if(patientAdmitViewModel.allPatients is null)
            {
                patientAdmitViewModel.allPatients = new List<Patient>();
            }
            //if(patientAdmitViewModel.GetPatientProblems is null)
            //{
            //    patientAdmitViewModel.GetPatientProblems = new List<PatientProblems>();
            //}
            PatientProblems PR = new PatientProblems();
            Treatment TR = new Treatment();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admit()
        {
            return View("PatientAdmit");
        }
        public IActionResult Problem(PatientProblems PR)
        {
            PR.problem = Request.Form["txtproblem"];
            patientAdmitViewModel.currentPatient.problems.Add(PR);
            return View("PatientDisplay",patientAdmitViewModel);
        }
        public IActionResult MySubmit(Patient obj)
        {
            obj.name = Request.Form["txtname"];
            obj.number = Request.Form["txtnumber"];
            obj.address = Request.Form["txtaddress"];
            if(patientAdmitViewModel.currentPatient is null)
            {
                patientAdmitViewModel.currentPatient = obj;
            }
            return View("PatientDisplay", patientAdmitViewModel);
        }
        public IActionResult Appointment()
        {
            patientAdmitViewModel.allPatients.Add(patientAdmitViewModel.currentPatient);
            patientAdmitViewModel.currentPatient = null;
            return View("PatientAppointment",patientAdmitViewModel);
        }
        public IActionResult AddTreatment(PatientProblems PR)
        {
            Treatment TR = new Treatment();
            TR.treatmentName = Request.Form["txttreatmentname"];
            TR.dose = Request.Form["txttreatmentdose"];
            PR.treatments.Add(TR);
            patientAdmitViewModel.currentPatient.problems.Add(PR);
            return View("PatientDisplay", patientAdmitViewModel);
            //return View("PatientDisplay", patientAdmitViewModel);
        }
        public IActionResult Treatment()
        {
            return View("PatientTreatment",patientAdmitViewModel);
        }
    }

}
