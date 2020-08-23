using HospitalPatient;
using HospitalStaff;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTreatment
{
    public class Treatment
    {
        public string Dose;
        public string Medication;
    }
    public class ProblemMappedToTreatment
    {
        List<Treatment> treatments = new List<Treatment>();

        List<PatientSymptoms> problems; // Retrieve The List Of Possible Problems From The DataBase
        public void MapTreatment()
        {
            //for every problem we can have Multiple Treatments
            //Map Every Problem With One Or Many Treatments
            //Load The Problems and Add Treatment DataBase Call
        }
    }
}
