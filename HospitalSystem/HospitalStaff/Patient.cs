using HospitalStaff;
using System;
using System.Collections.Generic;
using System.Text;
using PatientProblems;

namespace HospitalPatient
{
    public class Patient
    {

        public List<string> PatientSymptoms = new List<string>();
        //public String PatientSymptoms { get; set; } 
        //PatientSymptoms.Add("headache");
        Doctor DoctorName = new Doctor();
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public char PatientGender { get; set; }
        public string PhoneNumber { get; set; }
        protected int PatientId { get; set; }
        
        public string Description;

        
        public void AllocateDoctor()
        {
            ////Add doctor and Patient to Database (Insert Query)
            Console.WriteLine("Patient " + PatientName + " Is Assigned Doctor " + DoctorName.Name);
            DoctorName.ExaminePatient(PatientName);
        }

        public void LoadAllPatients(Doctor DoctorName)
        {
            ///We can do select query to load all patients for particular doctor 
        }

        public bool MakeAppointment()
        {
            return true;
        }
        public void PayBill(int Amount)
        {
            Console.WriteLine("The Patient : " + PatientName + "Has Made The Payment Amount : " + Amount);
        }
    }
}

