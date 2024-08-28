using System.Runtime.CompilerServices;

namespace Healthcare_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            Console.WriteLine("Welcome to the Healthcare Management application!");
            Console.WriteLine("Please choose one of the options below: ");
            Console.WriteLine("1. Add new patient");
            Console.WriteLine("2. Remove a patient");
            Console.WriteLine("3. Add new doctor");
            Console.WriteLine("4. Remove a doctor");
            Console.WriteLine("5. Add new nurse");
            Console.WriteLine("6. Remove nurse");
            Console.WriteLine("7. Make a new appointment");
            Console.WriteLine("8. Cancel an appointment");
            Console.WriteLine("9. Update medical record");
            Console.WriteLine("10. Remove medical record");
            Console.WriteLine("11. Display all information\n\n");

            while (true) 
            {
                Console.WriteLine("Choose an option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option < 0 || option > 11)
                {
                    Console.WriteLine("Invalid option. Please choose between 1 and 11");
                    continue;
                }
                else 
                {
                    Console.WriteLine("Option chosen is: " + option);

                    if (option == 1)
                    {
                        Console.WriteLine("Patient ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("First name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Last name: ");
                        string lastname = Console.ReadLine(); 

                        Patient patient = new Patient(firstname, lastname, id);
                        database.addPatient(patient);

                    }

                    else if (option == 2) 
                    {
                        Console.WriteLine("Patient ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        
                        database.removePatient(id);
                    }

                    else if(option == 3) 
                    {
                        Console.WriteLine("Doctor ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("First name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Last name: ");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Specialty: ");
                        string specialty = Console.ReadLine();

                        Doctor doctor = new Doctor(firstname, lastname, id, specialty);
                        database.addDoctor(doctor);
                    }
                    if (option == 4)
                    {
                        Console.WriteLine("Doctor ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        database.removeDoctor(id);
                    }

                    else if (option == 5)
                    {
                        Console.WriteLine("Nurse ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("First name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Last name: ");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Department: ");
                        string department = Console.ReadLine();

                        Nurse nurse = new Nurse(firstname, lastname, id, department);
                        database.addNurse(nurse);
                    }

                    else if (option == 6)
                    {
                        Console.WriteLine("Nurse ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        database.removeNurse(id);
                    }
                    if (option == 7)
                    {
                        Console.WriteLine("Patient ID: ");
                        int pa_id = Convert.ToInt32(Console.ReadLine());

                        if (database.CheckPatientExist(pa_id))
                        {
                            Patient patient = database.RetrievePatient(pa_id);
                            Console.WriteLine("Doctor ID: ");
                            int doc_id = Convert.ToInt32(Console.ReadLine());

                            if (database.CheckDoctorExist(doc_id))
                            {
                                Doctor doctor = database.RetrieveDoctor(doc_id);
                                Console.WriteLine("Enter day: ");
                                int day = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter month: ");
                                int month = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter year: ");
                                int year = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter hour: ");
                                int hour = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter min: ");
                                int min = Convert.ToInt32(Console.ReadLine());

                                DateTime date = new DateTime(day, month, year, hour, min);
                                Appointment appointment = new Appointment(date, doctor, patient);
                                Console.WriteLine("Appointment details: \n" + appointment.DisplayDetails());
                            }
                            else
                            {
                                Console.WriteLine("This doctor does not exist or has been removed from our database\n");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("This patient does not exist or has been removed from our database\n");
                            continue;
                        }
                    }

                    else if (option == 8)
                    {
                        Console.WriteLine("Appointment ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        database.removeAppointment(id);
                    }

                    else if (option == 9)
                    {
                        Console.WriteLine("Patient ID: ");
                        int pa_id = Convert.ToInt32(Console.ReadLine());

                        if (database.CheckPatientExist(pa_id))
                        {
                            if (database.CheckMedRecExist(pa_id))
                            {
                                Medical_Record record = database.RetrieveMedRec(pa_id);
                                Console.WriteLine("Current medical record: \n" + record.DisplayDetails());

                                Console.WriteLine("What would you like to update?");
                                Console.WriteLine("1. Doctor");
                                Console.WriteLine("2. Treatment");
                                Console.WriteLine("3. Diagnosis");
                                int ans = Convert.ToInt32(Console.ReadLine());

                                if (ans == 1)
                                {
                                    Console.WriteLine("Set doctor ID: ");
                                    int new_doc = Convert.ToInt32(Console.ReadLine());
                                    if (database.CheckDoctorExist(new_doc))
                                    {
                                        record.SetDoctorID(new_doc);
                                    }
                                    else
                                    {
                                        Console.WriteLine("This doctor does not exist or has been removed from our database\n");
                                        continue;
                                    }
                                }

                                else if (ans == 2)
                                {
                                    Console.WriteLine("Diagnosis: ");
                                    string new_diag = Console.ReadLine();
                                    if (new_diag != null)
                                    {
                                        record.SetDiagnosis(new_diag);
                                    }
                                    else
                                    {
                                        record.SetDiagnosis("");
                                    }
                                }

                                else if (ans == 3)
                                {
                                    Console.WriteLine("Treatment: ");
                                    string new_treatment = Console.ReadLine();
                                    if (new_treatment != null)
                                    {
                                        record.SetTreatment(new_treatment);
                                    }
                                    else
                                    {
                                        record.SetTreatment("");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Invalid option. Please choose between 1 and 3.");
                                }

                                Console.WriteLine("New medical record: \n" + record.DisplayDetails());

                            }
                            else
                            {
                                Patient patient = database.RetrievePatient(pa_id);
                                patient.GetMedicalRecord().SetPatientID(pa_id);

                                patient.GetMedicalRecord().SetID(pa_id);

                                Console.WriteLine("Set doctor ID: ");
                                int doc_id = Convert.ToInt32(Console.ReadLine());
                                if (database.CheckDoctorExist(doc_id))
                                {
                                    patient.GetMedicalRecord().SetDoctorID(doc_id);
                                }
                                else
                                {
                                    Console.WriteLine("This doctor does not exist or has been removed from our database\n");
                                    continue;
                                }

                                Console.WriteLine("Diagnosis: ");
                                string diag = Console.ReadLine();
                                if (diag != null)
                                {
                                    patient.GetMedicalRecord().SetDiagnosis(diag);
                                }
                                else
                                {
                                    patient.GetMedicalRecord().SetDiagnosis("");
                                }

                                Console.WriteLine("Treatment: ");
                                string treatment = Console.ReadLine();
                                if (treatment != null)
                                {
                                    patient.GetMedicalRecord().SetTreatment(treatment);
                                }
                                else
                                {
                                    patient.GetMedicalRecord().SetTreatment("");
                                }
                                Console.WriteLine("Medical Record is: \n" + patient.GetMedicalRecord().DisplayDetails());
                                database.addMedRec(patient.GetMedicalRecord());

                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Medical record of this patient does not exist or has been removed from our database\n");
                            continue;
                        }
                    }
                    else if (option == 10)
                    {
                        Console.WriteLine("Medical record ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        database.removeMedRec(id);
                    }

                    else if (option == 11)
                    {
                        database.DisplayAll();
                    }
                }

            }
        }
    }
}
