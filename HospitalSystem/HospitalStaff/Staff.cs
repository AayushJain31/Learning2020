using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using HospitalPatient;
using HospitalTreatment;
using PatientProblems;

namespace HospitalStaff
{
    public class Staff
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string Field;
        
    }
    public class Doctor : Staff
    {   
        public Nurse NR;
        public WardBoy WB;
        public int PatientCount = 0;
        public string Specialty { get; set; }
        public char Availability { get; set; }
        public void ExaminePatient(string PatientInfo)
        {
            PatientCount++;
            NR.AssistDoctor();
            WB.ArrangeWards();
            Treatment T = new Treatment();
            T.Dose = "1-0-1";
            T.Medication = "Aspirin";
            Problems PR = new Problems();
            PR.CheckSymptoms();   
        }
    }
    public class Nurse : Staff
    {
        public Doctor WorkDoctor;
        public void AssistDoctor()
        {
            Console.WriteLine("Nurse : " + Name + " Is Assisting Doctor " + WorkDoctor.Name);
        }
    }
    public class WardBoy : Staff
    {
        public void ArrangeWards()
        {
            Console.WriteLine("WardBoy Has Arranged The Wards.");
        }
    }
    public class Receptionist : Staff
    {
        public Doctor AssignDoctor;
        public Patient P;
        bool Confirm;
        public void ApproveAppointment()
        {
            Confirm = P.MakeAppointment();
            if (Confirm == true)
            {
                AssignDoctorToPatient();
            }
            else
            {
                Console.WriteLine("No Appointment Has Been Made.");
            }
        }
        public void AssignDoctorToPatient()
        {
            if (AssignDoctor.Availability == 'Y')
            {
                P.AllocateDoctor(AssignDoctor.Name);
            }
            else
            {
                Console.WriteLine("Doctor Is Not available For Check Up Today.");
            }
        }
        public void CollectPayment()
        {
            int cost = 1234;
            P.PayBill(cost);
        }
    }

    public class Accountant : Staff
    {
        public Doctor DR;
        public void CalSalary()
        {   
            int salary = DR.PatientCount * 5000 + 20000;
            Console.WriteLine("Doctor's Salary : ", salary);
            salary = 15000;
            Console.WriteLine("Nurse's Salary : ", salary);
            salary = 9000;
            Console.WriteLine("WardBoy's Salary : ", salary);
            salary = 20000;
            Console.WriteLine("Receptionist's Salary : ", salary);
        }
    }
}
