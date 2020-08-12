using HospitalStaff;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalPatient
{
    public class Patient
    {
        public Doctor D;
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public char PatientGender { get; set; }
        protected int PatientId { get; set; }
        public bool WantAppointment;
        
        public string Description;
        public void AllocateDoctor(string DoctorName)
        {
            Console.WriteLine("Patient " + PatientName + " Is Assigned Doctor " + DoctorName);
            D.ExaminePatient(PatientName);
        }
        public bool MakeAppointment()
        {
            if(WantAppointment ==  true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PayBill(int Amount)
        {
            Console.WriteLine("The Patient : " + PatientName + "Has Made The Payment Amount : " + Amount);
        }
    }
}

//public class Doctor
//{
//    public string DoctorName { get; set; }
//    public string DoctorAddress { get; set; }
//    public char DoctorGender { get; set; }
//    public int DoctorId { get; set; }
//    public bool IsDoctorAvailable { get; set; }
//    public string Specialty { get; set; }
//    //public Hospital DoctorSalary;
//    short count = 0;
//    public void Examine(Patient P)
//    {

//        int GetPatient = P.AllocateDoctor();
//        if (GetPatient != 0)
//        {
//            count++;
//        }
//    }
//    public int FindNurse(int NurseId)
//    {
//        return NurseId;
//    }
//    public string GivePrescription()
//    {
//        return "";
//    }
//}
//public class Nurse
//{
//    public Doctor GetDoctor;
//    public string NurseName { get; set; }
//    public string NurseAddress { get; set; }
//    public char NurseGender { get; set; }
//    public int NurseId { get; set; }
//    public void FindDoctor()
//    {
//        int WorkDoctor = GetDoctor.FindNurse(NurseId);
//    }
//}
//public class WardBoy
//{
//    public string WardBoyName { get; set; }
//    public string WardBoyAddress { get; set; }
//    public int WardBoyId { get; set; }
//    public void SetUpWard()
//    {

//    }
//}
//public class Admin
//{
//    public Doctor CheckDoctor;
//    public Patient PatientDetails;
//    public string AdminName { get; set; }
//    public string AdminAddress { get; set; }
//    public char AdminGender { get; set; }
//    public int AdminId { get; set; }
//    public void AdmitPatient()
//    {
//        if (CheckDoctor.IsDoctorAvailable == true)
//        {
//            int PatientNumber = PatientDetails.AllocateDoctor();

//        }
//    }
//    public void CollectBill()
//    {
//        int BillAmount = PatientDetails.PayBill();
//        Console.WriteLine("Bill received!!!");
//    }

//}