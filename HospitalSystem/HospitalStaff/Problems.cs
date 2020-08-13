using HospitalPatient;
using HospitalTreatment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientProblems
{ 
    public class Problems
    {
        public List<Treatment> TT;
        String[] Symptoms = new String[]{"cough" , "cold" , "fever" , "headache" , "nausea" , "accident" , "eye problem" , "cancer"};
        public void CheckSymptoms(Patient PT)
        {
            if (Array.Find(Symptoms , PT.PatientSymptoms) != null)
            {
                TT.ProvideTreatment();
            }
        }
    }
}
