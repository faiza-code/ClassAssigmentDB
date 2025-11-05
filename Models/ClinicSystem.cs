using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Models
{
    public class ClinicSystem
    {
        private List<Patient> patients = new();
        private List<Doctor> doctors = new();
        private List<Appointment> appointments = new();


        private int nextPatientID = 1;
        private int nextDoctorID = 1;
        private int nextAppointmentID = 1;

        // Function to RegisterPatient ....
        public Patient RegisterPatient(int patient_ID,string firstname, string lastname)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                Console.WriteLine($"PLASE ENTER YOUR FIRST AND LAST NAME");
                return null;
            }
            
            return new Patient(patient_ID,firstname, lastname);

            // Add Patient to List :
            var patient = new Patient(nextPatientID++, firstname,lastname );
            patients.Add(patient);
            Console.WriteLine("✅ Patient registered successfully!");
            return patient;


        }
        //Function to RegisterDoctor :
        public Doctor RegisterDoctor(int doctor_ID, string first_Name, string last_Name, string specialty)
        {
            if (string.IsNullOrEmpty(first_Name) || string.IsNullOrEmpty(last_Name))
            {
                Console.WriteLine($"PLASE ENTER YOUR FIRST AND LAST NAME");
                return null;
            }

            return new Doctor(doctor_ID, first_Name, last_Name, specialty);

            // Add Doctor to List :
            var doctor = new Doctor(nextDoctorID++,first_Name, last_Name, specialty);
            doctors.Add(doctor);
            Console.WriteLine(doctor.Doctor_ID + "✅ Doctor added successfully!");
            return doctor;


        }


        //Allow patients to search for doctors by specialty.

        public List<Doctor> Search(string specialty)
        {
            var list = new List<Doctor>();
            foreach (Doctor element in doctors)
            {
                if (string.Equals(element.Specialty, specialty, StringComparison.OrdinalIgnoreCase))
                {
                    list.Add(element);
                }
            }

            Console.WriteLine("🔎 Doctors Found:");
            return list;
        }

        //Schedule appointments between patients and doctors.
        public bool ScheduleAppointment(int patientID, int doctorID, DateTime date)
        {
            var patient = patients.FirstOrDefault(p => p.Patient_ID == patientID);
            var doctor = doctors.FirstOrDefault(d => d.Doctor_ID == doctorID);

            if (patient == null || doctor == null)
            {
                Console.WriteLine("Invalid patient or doctor ID.");
                return false;
            }

            if (appointments.Any(a => a.Doctor.Doctor_ID == doctorID && a.Date == date.Date))
            {
                Console.WriteLine("Doctor is already booked on this date.");
                return false;
            }

            var appointment = new Appointment(nextAppointmentID++, patient, doctor, date);
            appointments.Add(appointment);
            Console.WriteLine("Appointment scheduled successfully.");
            return true;
        }

        //View all appointments for a given patient...
        public void ViewAppointmentsPatient(int patientID)
        {
            var patientAppointments = appointments.Where(a => a.Patient.Patient_ID == patientID).ToList();
            if (patientAppointments == null)
            {
                Console.WriteLine("No appointments found for this patient.");
                return;
            }
            foreach (Appointment appt in patientAppointments)
            {
                Console.WriteLine($"Appointment ID: {appt.AppointmentID}" +
                    $" Doctor: Dr. {appt.Doctor.First_Name} {appt.Doctor.Last_Name} ({appt.Doctor.Specialty})" +
                    $"Date: {appt.Date:yyyy-MM-dd}");
            }
        }

        //View the complete appointment list...
        public void ViewPpointments()
        {
            if (appointments == null)
            {
                Console.WriteLine("No Appointments Fonud");
                return;
            }
            foreach (Appointment appt in appointments)
            {
                Console.WriteLine($"Appointment ID: {appt.AppointmentID}" +
                             $" Patient: {appt.Patient.First_Name} {appt.Patient.Last_Name}" +
                             $" Doctor: Dr. {appt.Doctor.First_Name} {appt.Doctor.Last_Name} ({appt.Doctor.Specialty})" +
                             $" Date: {appt.Date:yyyy-MM-dd}");
            }
        }
















    }
}
