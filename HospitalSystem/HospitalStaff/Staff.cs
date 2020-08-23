using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using HospitalPatient;
using HospitalTreatment;

namespace HospitalStaff
{
    public class Staff
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class Doctor : Staff
    {   
        //Nurse NR = new Nurse();
        //WardBoy WB = new WardBoy();
        Patient objPatient = new Patient();
        public List<Treatment> TT = new List<Treatment>();

        public int PatientCount = 0;
        public string Specialty { get; set; }
        public char Availability { get; set; }

        public void ExaminePatient(Nurse NR , WardBoy WB , Patient objPatient)
        {
            NR.AssistDoctor();
            WB.ArrangeWards();
            //Doctor Takes A Look At Patient Symptoms And Allergies
            //LookUpProblems();
            //LookUpAllegies();
            ProvideTreatment(objPatient);
        }

        public void ProvideTreatment(Patient objPatient)
        {
            //Look Up The Patient Problems and Provide Appropriate Treatment 
            Console.WriteLine("The Patient Should Take The Following Medication According To The Dose Given : ");
            foreach (var item in objPatient.patientSymptoms)
            {  
                Console.WriteLine("Enter The Dose And Medication For {0}", item.name);
                TT.Add(new Treatment() { Dose = Console.ReadLine(), Medication = Console.ReadLine() });
            }
            Receptionist RP = new Receptionist();
            RP.CollectPayment(objPatient);

        }

        public void LoadAllPatients()
        {
            //Query Made By Particular Doctor To Get A List Of His Patients and Appointments
        }

        public void DoctorSupportingNurses(Nurse NR)
        {
            NR.LoadAllNurses(this);
        }
    }


public class Nurse : Staff
    {
        public Doctor WorkDoctor = new Doctor();
        public void AssistDoctor()
        {
            Console.WriteLine("Nurse : " + Name + " Is Assisting Doctor " + WorkDoctor.Name);
        }

        public void LoadAllNurses(Doctor WorkDoctor)
        {
            //get load all staff nurses also load nurses as per doctor names
        }
        public void AttendPatient(Patient P)
        {
            //Nurse Attends The Current Patient
            //Entry added To The Database
        }
    }
    public class WardBoy : Staff
    {
        public void ArrangeWards()
        {
            Console.WriteLine("WardBoy Has Arranged The Wards.");
        }
        public void AttendPatient(Patient P)
        {
            //WardBoy Attends The Current Patient
            //Entry added To The Database
        }
    }
    public class Receptionist : Staff
    {
        bool Confirm;
        public void ApproveAppointment(Doctor AssignDoctor , Nurse N , WardBoy W , Patient P)
        {
            Confirm = P.MakeAppointment;
            if (Confirm == true)
            {
                AssignDoctorToPatient(AssignDoctor , N , W , P);
            }
            else
            {
                Console.WriteLine("No Appointment Has Been Made.");
            }
        }
        public void AssignDoctorToPatient(Doctor AssignDoctor , Nurse N , WardBoy W , Patient P)
        {
            if (AssignDoctor.Availability == 'Y')
            {
                AssignDoctor.PatientCount++;
                //Make A DataBase Entry For The Patient Against Doctor 
                Console.WriteLine("The Patient : {0} Has Been Allocated Doctor {1}", P.PatientName,AssignDoctor.Name);
                AssignDoctor.ExaminePatient(N,W,P);
            }
            else
            {
                Console.WriteLine("Doctor Is Not available For Check Up Today.");
            }
        }
        public void CollectPayment(Patient P)
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
