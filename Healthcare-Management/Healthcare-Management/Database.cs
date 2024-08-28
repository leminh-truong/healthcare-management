using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class Database
    {
        private List<Doctor> doctors = new List<Doctor>();
        private List<Nurse> nurses = new List<Nurse>();
        private List<Patient> patients = new List<Patient>();
        private List<Appointment> appointments = new List<Appointment>();
        private List<Medical_Record> medicical_records = new List<Medical_Record>();
        public Database() { }

        public bool CheckDoctorExist(int id)
        {
           return doctors.Any(doctor => doctor.GetID() == id);
        }

        public Doctor RetrieveDoctor(int id)
        {
            var doc = doctors.Find(doctor => doctor.GetID() == id);
            return doc;
        }
        public void addDoctor(Doctor doctor)
        {
            doctors.Add(doctor); 
        }

        public void removeDoctor(int id)
        {
            doctors.RemoveAll(doctor => doctor.GetID() == id); 
        }

        public bool CheckNurseExist(int id)
        {
            return nurses.Any(nurse => nurse.GetID() == id);
        }

        public Nurse RetrieveNurse(int id)
        {
            var nurse = nurses.Find(nurse => nurse.GetID() == id);
            return nurse;
        }

        public void addNurse(Nurse nurse)
        {
            nurses.Add(nurse);
        }

        public void removeNurse(int id)
        {
            nurses.RemoveAll(nurse => nurse.GetID() == id);
        }

        public bool CheckPatientExist(int id)
        {
            return patients.Any(patient => patient.GetID() == id);
        }

        public Patient RetrievePatient(int id)
        {
            var patient = patients.Find(patient => patient.GetID() == id);
            return patient;
        }
        public void addPatient(Patient patient)
        {
            patients.Add(patient); 
        }

        public void removePatient(int id)
        {
            patients.RemoveAll(patient => patient.GetID() == id);
        }

        public bool CheckAppointmentExist(int id)
        {
            return appointments.Any(appointment => appointment.getId() == id);
        }

        public Appointment RetrieveAppointment(int id)
        {
            var appointment = appointments.Find(appointment => appointment.getId() == id);
            return appointment;
        }
        public void addAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        public void removeAppointment(int id)
        {
            var appointment = appointments.Find(appointment => appointment.getId() == id);
            appointment.cancel();
        }

        public bool CheckMedRecExist(int id)
        {
            return medicical_records.Any(medicical_record => medicical_record.GetID() == id);
        }

        public Medical_Record RetrieveMedRec(int id)
        {
            var medicical_record = medicical_records.Find(medicical_record => medicical_record.GetID() == id);
            return medicical_record;
        }
        public void addMedRec(Medical_Record medicical_record)
        {
            medicical_records.Add(medicical_record);
        }

        public void removeMedRec(int id)
        {
            medicical_records.RemoveAll(medicical_record => medicical_record.GetID() == id);
        }

        public void DisplayAll()
        {
            Console.WriteLine("Doctors:\n");
            foreach(var doctor in doctors)
            {
                Console.WriteLine(doctor.Report());
            }
            Console.WriteLine("Nurses:\n");
            foreach (var nurse in nurses)
            {
                Console.WriteLine(nurse.Report());
            }
            Console.WriteLine("Patients:\n");
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.Report());
            }
            Console.WriteLine("Appointments:\n");
            foreach (var appointment in appointments)
            {
                Console.WriteLine(appointment.DisplayDetails());
            }

            Console.WriteLine("Medical Records:\n");
            foreach(var medical_record in medicical_records)
            {
                Console.WriteLine(medical_record.Report());
            }
        }
    }
}
