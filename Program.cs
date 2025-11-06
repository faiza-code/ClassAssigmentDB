using OmanClinicSystem.Models;

namespace OmanClinicSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClinicSystem clinicSystem = new ClinicSystem();

            while (true)
            {
                Console.WriteLine("WELCOME TO OMAN CLINIC SYSTEM");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Clinic Appointment System Menu:");
                Console.WriteLine("1)Register Patient\n2)Register Doctor\n3)Search Doctors by Specialty\n4)Schedule Appointment\n5)View Appointments for Patient\n6)View All Appointments");
                Console.Write("PLEASE ENTER NUMBER TO CHOIEC YOU SERVISE :");
                int user = int.Parse(Console.ReadLine());

                switch (user)
                {
                    case 1:
                        Console.WriteLine("-- Register New Patient --");
                        Console.Write("Enter Your Civial ID Number :");
                        int idnumber = int.Parse(Console.ReadLine());
                        Console.Write("First Name: ");
                        string FirstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string LastName = Console.ReadLine();
                        clinicSystem.RegisterPatient(idnumber, FirstName, LastName);

                        break;
                    case 2:
                        Console.WriteLine("-- Add New Doctor --");
                        Console.Write("Enter Your Civial ID Number :");
                        int idDoctor = int.Parse(Console.ReadLine());
                        Console.Write("First Name: ");
                        string FirstName1 = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string LastName2 = Console.ReadLine();
                        clinicSystem.RegisterPatient(idDoctor, FirstName1, LastName2);

                        break;
                    case 3:
                        Console.WriteLine("-- Search Doctor by Specialty --");
                        Console.Write("Enter Specialty to Search: ");
                        string searchSpecialty = Console.ReadLine();
                        var foundDoctors = clinicSystem.Search(searchSpecialty);

                        if (foundDoctors.Count == 0)
                        {
                            Console.WriteLine("No doctors found with this specialty.");
                        }
                        else
                        {
                            foreach (var doc in foundDoctors)
                                Console.WriteLine($"ID: {doc.Doctor_ID}, Dr. {doc.First_Name} {doc.Last_Name}");
                        }

                        break;
                    case 4:
                        Console.WriteLine("-- Book Appointment --");
                        Console.Write("Enter Patient ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int patientID))
                        {
                            Console.WriteLine("Invalid patient ID.");
                            break;
                        }
                        Console.Write("Enter Doctor ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int doctorID))
                        {
                            Console.WriteLine("Invalid doctor ID.");
                            break;
                        }
                        Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
                        if (!DateTime.TryParse(Console.ReadLine(), out DateTime appDate))
                        {
                            Console.WriteLine("Invalid date format.");
                            break;
                        }
                        clinicSystem.ScheduleAppointment(patientID, doctorID, appDate);

                        break;
                    case 5:
                        Console.WriteLine("-- View Patient Appointments --");
                        Console.Write("Enter Patient MR Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int patID))
                        {
                            Console.WriteLine("Invalid patient ID.");
                            break;
                        }
                        clinicSystem.ViewAppointmentsPatient(patID);

                        break;
                    case 6:
                        Console.WriteLine("-- View All Appointments --");
                        clinicSystem.ViewPpointments();
                        break;
                    default:
                        Console.WriteLine("INVALID OPICION ENTER YOUR CHOIC !!!\n👋 Thank you for using Oman Clinic Appointment System. Goodbye!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
