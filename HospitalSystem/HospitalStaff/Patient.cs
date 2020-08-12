using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalPatient
{
    public class Patient
    {
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public char PatientGender { get; set; }
        public int PatientId { get; set; }
        public int AllocateDoctor()
        {
            int PatientNumber = PatientId;
            return PatientNumber;
        }
        public void MakeAppointment()
        {

        }
        public int PayBill()
        {
            int Amount = 1234566543;
            return Amount;
        }
    }
}
