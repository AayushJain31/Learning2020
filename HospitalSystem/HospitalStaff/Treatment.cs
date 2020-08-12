using HospitalStaff;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalTreatment
{
    public class Treatment
    {
        public string Dose;
        public string Medication;
        public void ProvideTreatment()
        {
            Console.WriteLine("The Patient Should Take The Following Medication : " + Medication + " In The Following Manner : " + Dose);
            Receptionist RP = new Receptionist();
            RP.CollectPayment();
        }
    }
}
