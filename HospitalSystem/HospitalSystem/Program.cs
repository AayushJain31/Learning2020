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
            Console.WriteLine("Is Emergency? (Yes OR No) ");
            P.nature = Console.ReadLine();
            if(P.nature == "Yes")
            {
                Console.WriteLine("Emergency Case!!!Admit The Patient Immediately And Call The Doctor For Operating");
                //Since The Case Is Emergency The Details Can Be Taken Later. 
            }
            else
            {
                Console.WriteLine("Patient Name : ");
                P.PatientName = Console.ReadLine();
                Console.WriteLine("Patient Number : ");
                P.PatientNumber = Console.ReadLine();
                //P.PatientName = "XYZ"; //set the property
                //string Name = P.PatientName;
                P.PatientAddress = "Mumbai";
                P.PatientNumber = "123456";
                P.patientAllergies.Add(new Allergies() { name = "Pollen Allergy", description = "Sneeze,Itchy Eyes", duration = "5 years" });
                P.patientSymptoms.Add(new PatientSymptoms() { name = "Viral fever", description = "Head Ache.Body Pain", duration = "2 Days" });
                P.patientSymptoms.Add(new PatientSymptoms() { name = "Cold", description = "Runny Nose,Sneezing", duration = "3 Days" });

                P.visit = true;
                P.VisitEntry();

                Nurse N = new Nurse();
                N.Name = "ABC";
                N.Address = "ChurchGate";

                WardBoy W = new WardBoy();
                W.Name = "PQR";
                W.Address = "Dadar";

                Doctor D = new Doctor();
                D.Name = "XYZ";
                D.Address = "Mumbai";
                D.Availability = 'Y';
                D.Specialty = "Physician MD";

                Receptionist RP = new Receptionist();
                RP.ApproveAppointment(D, N, W, P);
            }
            

            //Accountant AC = new Accountant();
            //AC.CalSalary(D);

            Console.WriteLine("-----Complete-----");
            Console.Read();
        }
    }
}
