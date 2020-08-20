using System;
using System.Collections.Generic;

namespace PatientLibrary
{
    public class Patient
    {
        public string name { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public List<PatientProblems> problem { get; set; }
        
    }
    public class PatientProblems
    {
        public string problem { get; set; }
    }
}
