using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Models
{
    public class Patient
    {
        public int Patient_ID { get; }
        public string First_Name { get; }
        public string Last_Name { get; }

        public Patient(int patient_ID, string first_Name, string last_Name)
        {
            Patient_ID = patient_ID;
            First_Name = first_Name;
            Last_Name = last_Name;
        }
    }

}
