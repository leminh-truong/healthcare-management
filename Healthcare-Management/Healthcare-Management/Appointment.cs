using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class Appointment
    {
        private DateTime date;
        private Doctor doctor;
        private Patient patient;
        private bool cancelled = false;
        private int ID;
        public Appointment(DateTime date, Doctor doctor, Patient patient) 
        { 
            this.date = date;
            this.doctor = doctor;
            this.patient = patient;
            this.ID = Int32.Parse(doctor.GetID().ToString() + patient.GetID().ToString());
        }

        public void cancel() { cancelled = true; }
        public DateTime getDate() { return date; }
        public void setDate(DateTime date) { this.date = date; }
        public Doctor getDoctor() { return doctor; }
        public Patient getPatient() { return patient; }

        public int getId() { return ID; }

        public bool isCancelled() { return cancelled; }

        public string DisplayDetails()
        {
            return "Appointment ID: " + this.ID + " Date and Time: " + this.date.DisplayDatetime() + "\nDoctor: " + this.doctor.DisplayDetails() + "\nPatient: " + this.patient.DisplayDetails() + "\nCancelled: " + this.cancelled;
        }
        
    }
}
