using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class Doctor : Personnel
    {
        private string firstName;
        private string lastName;
        private int ID;
        private string specialty;
        public Doctor(string firstName, string lastName, int ID, string specialty)
        {
            this.specialty = specialty;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;
        }

        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public int GetID() { return ID; }
        public string GetSpecialty() { return specialty; }
        public void SetFirstName(string firstName)
        {
            this.firstName=firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }

        public void SetSpecialty(string specialty)
        {
            this.specialty = specialty;
        }

        public override string Report()
        {
            return "Role: Doctor, ID: " + this.ID + ", Name: " + this.firstName + " " + this.lastName + ", Specialty: " + this.specialty + "\n";
        }

        public override string DisplayDetails()
        {
            return "ID: " + this.ID + ", Name: " + this.firstName + " " + this.lastName + ", Specialty: " + this.specialty + "\n";
        }
    }
}
