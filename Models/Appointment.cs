using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }

        public Appointment(int appointmentID, Patient patient, Doctor doctor, DateTime date)
        {
            AppointmentID = appointmentID;
            Patient = patient;
            Doctor = doctor;
            Date = date;
        }

    }
}
