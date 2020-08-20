using System;
using HospitalStaff;
using HospitalPatient;
using System.Collections.Generic;
using PatientProblems;
using System.Linq;

namespace HospitalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Start-----");

            Doctor D = new Doctor();
            D.Name = "XYZ";
            D.Availability = 'Y';

            Patient P = new Patient();
            List<Patient> PT = new List<Patient>();
            P.Description = "headache,cold,fever";

            PT.Add(new Patient()
            {
                PatientName = "XYZ",
                PatientAddress = "Mumbai",
                PhoneNumber = "123456",
                PatientGender = 'M',
                PatientSymptoms = P.Description.Split(",").ToList()
            }) ;

            P.AllocateDoctor();

            Receptionist RP = new Receptionist();
            RP.ApproveAppointment();

            Accountant AC = new Accountant();
            AC.CalSalary();

            Console.WriteLine("-----Complete-----");
            Console.Read();
        }
    }
}
