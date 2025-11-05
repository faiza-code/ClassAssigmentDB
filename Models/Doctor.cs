using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Models
{
     public class Doctor
    {
        public int Doctor_ID { get; set; }
        public string First_Name { get; }
        public string Last_Name { get; }
        public string Specialty { get; }

        public Doctor(int doctor_ID, string first_Name, string last_Name, string specialty)
        {
            Doctor_ID = doctor_ID;
            First_Name = first_Name;
            Last_Name = last_Name;
            Specialty = specialty;
        }

    }
}
