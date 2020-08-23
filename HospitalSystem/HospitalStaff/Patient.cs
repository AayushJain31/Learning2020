using HospitalStaff;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalPatient
{
    public class Patient
    {
        
        public List<Allergies> patientAllergies = new List<Allergies>(); //Compostion

        public List<PatientSymptoms> patientSymptoms = new List<PatientSymptoms>(); //Aggregation

        private string _Name;
        public string PatientName
        {
            get { return _Name; }
            set { 
                if(value.Equals(""))
                {
                    throw new Exception("Patient Name cannot ne NULL/EMPTY!!!");
                }
                else
                {
                    _Name = value;
                } 
            }
        }

        private string _Number;

        public string PatientNumber
        {
            get { return _Number; }
            set {
                if (value.Length == 0)
                {
                    throw new Exception("Patient Number cannot ne NULL/EMPTY!!!");
                }
                else
                {
                    _Number = value;
                }
            }
        }

        public string PatientAddress { get; set; }

        public bool visit;
        public List<DateTime> visitLog = new List<DateTime>(); //Stores Every Visit Time Log For The Patient

        public bool MakeAppointment = true;
        public void VisitEntry()
        {
            if (visit == true)
            {
                visitLog.Add(DateTime.Now);
            }
        }

        public void InsertPatient()
        {
            //We can do Insert Query To Add The Patient Details to The DataBase.
        }

        public void PayBill(int Amount) //Pascal Case
        {
            Console.WriteLine("The Patient : " + PatientName + "Has Made The Payment Amount : " + Amount);
        }
    }

    public interface IPatientProblems
    {
        public string name { get; set; } //Camel Case
        public string description { get; set; } //Camel Case
        public string duration { get; set; } //Camel Case
    }
    public class Allergies : IPatientProblems
    {
        public string name { get; set; } //Camel Case
        public string description { get; set; } //Camel Case
        public string duration { get; set; } //Camel Case
    }

    public class PatientSymptoms : IPatientProblems
    {
        public string name { get; set; } //Camel Case
        public string description { get; set; } //Camel Case
        public string duration { get; set; } //Camel Case
    }
}

