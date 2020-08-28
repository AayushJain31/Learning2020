using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientLibrary
{   
    public interface IPatient
    {
        string name { get; set; }
        string address { get; set; }
        public string number { get; set; }
        List<PatientProblems> problems { get; set; }
    }
    public class PatientDTO
    {
        public virtual string name { get; set; }
        public virtual string address { get; set; }
        public virtual string number { get; set; }
        public virtual string email { get; set; }
        public virtual List<PatientProblems> problems { get; set; }
    }

    public class Patient : PatientDTO , IPatient
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name Is Required!")]
        public override string name { get; set; }
        public override string address { get; set; }
        [Required(ErrorMessage = "The Phone Number Is Required!")]
        public override string number { get; set; }
        //[RegularExpression(@"^[a-z]{3,8}.[a-z]{3-8}@[a-z]{3-10}.[a-z]{2,3}$")]
        [Required(ErrorMessage = "The Email Address Is Required!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public override string email { get; set; }
        public override List<PatientProblems> problems { get; set; }
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
        public int Id { get; set; }
        public string problem { get; set; }
        public List<Treatment> treatments { get; set; }
        public PatientProblems()
        {
            this.treatments = new List<Treatment>();
        }
    }
    public class Treatment
    {
        public int Id { get; set; }
        public string treatmentName { get; set; }
        public string dose { get; set; }
    }
}
