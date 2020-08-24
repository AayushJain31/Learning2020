using System;
using System.Collections.Generic;

namespace PatientLibrary
{   
    public interface IPatient
    {
        string name { get; set; }
        string address { get; set; }
        public string number { get; set; }
        List<PatientProblems> problems { get; set; }
    }
    public class Patient : IPatient
    {
        public string name { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public List<PatientProblems> problems { get; set; }
        public string guid { get; set; }

        public Patient()
        {
            this.problems = new List<PatientProblems>();
            this.guid = Guid.NewGuid().ToString();
        }

        public virtual bool Validate() 
        {
            if(name == " ")
            {
                throw new Exception("Name Needed");
            }
            return true;
        }
    }
    public class PatientCheckAddress : Patient , IPatient
    {
        public override bool Validate()
        {
            if (name == " ")
            {
                throw new Exception("Name Needed");
            }
            if (address == " ")
            {
                throw new Exception("Address Needed");
            }

            return true;
        }
    }
    public class PatientProblems
    {
        public string problem { get; set; }
        public List<Treatment> treatments { get; set; }

        public PatientProblems()
        {
            this.treatments = new List<Treatment>();
        }
    }

    public class Treatment
    {
        public string treatmentName { get; set; }

        public string dose { get; set; }
    }
}
