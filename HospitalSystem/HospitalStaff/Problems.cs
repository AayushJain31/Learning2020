using HospitalPatient;
using HospitalTreatment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientProblems
{ 
    public class Problems
    {
        public List<Treatment> TT; //Multiple problems can have Multiple Treatments
        //There will be list of Symptoms in the database
        public List<PatientSymptoms> Symptoms = new List<PatientSymptoms>();
        
        public void CheckSymptoms(Patient PT)
        {
            //Map Symptoms with Treatment and provide Appropriate Treatment
            //if (Array.Find(Symptoms , PT.PatientSymptoms) != null)
            //{
            //    TT.ProvideTreatment();
            //}
        }
    }
    public class PatientSymptoms
    {
    public string problem { get; set; }
}
}
