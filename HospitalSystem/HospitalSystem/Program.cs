using System;
using HospitalStaff;
using HospitalPatient;
using System.Collections.Generic;
using System.Linq;

namespace HospitalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Start-----");

            Patient P = new Patient();
            //List<Patient> PT = new List<Patient>();
            P.PatientName = "XYZ"; //set the property
            //string Name = P.PatientName;
            P.PatientAddress = "Mumbai";
            P.PatientNumber = "123456";
            P.patientAllergies.Add(new Allergies() { name = "Pollen Allergy" , description = "Sneeze,Itchy Eyes" , duration = "5 years" });
            P.patientSymptoms.Add(new PatientSymptoms() { name = "Viral fever", description = "Head Ache.Body Pain", duration = "2 Days" });
            P.patientSymptoms.Add(new PatientSymptoms() { name = "Cold", description = "Runny Nose,Sneezing", duration = "3 Days" });

            P.visit = true;
            P.VisitEntry();

            Nurse N = new Nurse();
            N.Name = "ABC";


            WardBoy W = new WardBoy();
            W.Name = "PQR";

            Doctor D = new Doctor();
            D.Name = "XYZ";
            D.Availability = 'Y';
            D.Specialty = "Physician MD";

            Receptionist RP = new Receptionist();
            RP.ApproveAppointment(D , N , W , P);

            //Accountant AC = new Accountant();
            //AC.CalSalary();

            Console.WriteLine("-----Complete-----");
            Console.Read();
        }
    }
}
