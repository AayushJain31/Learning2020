using HospitalStaff;
using HospitalTreatment;
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
                try
                {
                    if (value.Equals("")) //Patient Name is Compulsory
                    {
                        throw new Exception();
                    }
                    else
                    {
                        _Name = value;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Patient Name cannot ne NULL / EMPTY!!! Close The Application And Enter Again");
                }
                
            }
        }

        private string _Number;

        public string PatientNumber
        {
            get { return _Number; }
            set {
                if (value.Length == 0) //Patient Number Is Compulsory
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

        public string nature;
        
        public List<DateTime> visitLog = new List<DateTime>(); //Stores Every Visit Time Log For The Patient

        public bool MakeAppointment = true;
        public void VisitEntry()
        {
            if (visit == true)
            {
                visitLog.Add(DateTime.Now);
                Console.WriteLine("The Patient {0} Has Visited The Hospital At The Time : {1}",PatientName , DateTime.Now );
            }
        }

        public void InsertPatient(Patient P)
        {
            //We can do Insert Query To Add The Patient Details to The DataBase.
            List<Patient> patients = new List<Patient>();
            patients.Add(P);
        }

        public void PayBill(int Amount) //Pascal Case
        {
            Console.WriteLine("The Patient : " + PatientName + " Has Made The Payment Amount : " + Amount);
        }

    }

    public interface IPatientProblems //Common Interface For Allergies And Problems 
    {
        public string name { get; set; } //Camel Case
        public string description { get; set; } //Camel Case
        public string duration { get; set; } //Camel Case
    }
    public class Allergies : IPatientProblems //Class Implements Interface
    {
        public string name { get; set; } //Camel Case
        public string description { get; set; } //Camel Case
        public string duration { get; set; } //Camel Case
    }

    public class PatientSymptoms : IPatientProblems //Class Implements Interface
    {
        public string name { get; set; } //Camel Case
        public string description { get; set; } //Camel Case
        public string duration { get; set; } //Camel Case
        public List<Treatment> treatments { get; set; }
    }
}

