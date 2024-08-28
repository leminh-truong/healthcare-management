using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class Patient
    {
        private string firstName;
        private string lastName;
        private int ID;
        private Medical_Record medical_record = new Medical_Record();
        public Patient(string firstName, string lastName, int ID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;
        }

        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public int GetID() { return ID; }
        public Medical_Record GetMedicalRecord() { return medical_record; }
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }

        public string Report()
        {
            return "Role: Patient, ID: " + this.ID + ", Name: " + this.firstName + " " + this.lastName + ",\nMedical History: \n " + this.medical_record.DisplayDetails() +"\n";
        }

        public string DisplayDetails()
        {
            return "ID: " + this.ID + ", Name: " + this.firstName + " " + this.lastName + ", Medical History: \n" + this.medical_record.DisplayDetails() + "\n";
        }
    }
}
