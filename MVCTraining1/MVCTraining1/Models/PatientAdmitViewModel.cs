using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PatientLibrary;

namespace MVCTraining1.Models
{
    public class PatientAdmitViewModel
    {
        public PatientAdmitViewModel()
        {
            errors = new List<ValidationResult>();
        }
        public List<Patient> allPatients { get; set; }
        public Patient currentPatient { get; set; }
        public List<ValidationResult> errors { get; set; }

        public Patient query { get; set; }
    }
}
