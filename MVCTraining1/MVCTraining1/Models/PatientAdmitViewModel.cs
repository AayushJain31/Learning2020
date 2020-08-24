using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientLibrary;

namespace MVCTraining1.Models
{
    public class PatientAdmitViewModel
    {
        public List<Patient> allPatients { get; set; }
        public Patient currentPatient { get; set; }
        
        //public List<PatientProblems> GetPatientProblems { get; set; }
    }
}
