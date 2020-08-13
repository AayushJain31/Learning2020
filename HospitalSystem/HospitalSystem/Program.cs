using System;
using HospitalStaff;
using HospitalPatient;


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
            P.PatientName = "ABC";
            P.WantAppointment = true;
            P.Description = "headache";
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
