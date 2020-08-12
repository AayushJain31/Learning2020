using HospitalPatient;
using HospitalTreatment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientProblems
{ 
    public class Problems
    {
        public Patient PT;
        public Treatment TT;
        String[] Symptoms = new String[]{"cough" , "cold" , "fever" , "headache" , "nausea" , "accident" , "eye problem" , "cancer"};
        public void CheckSymptoms()
        {
            if (Array.Find(Symptoms , PT.Description.Contains) != null)
            {
                TT.ProvideTreatment();
            }
        }
    }
}
