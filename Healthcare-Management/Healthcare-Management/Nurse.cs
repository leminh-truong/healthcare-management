using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class Nurse : Personnel
    {
        private string firstName;
        private string lastName;
        private int ID;
        private string department;
        public Nurse(string firstName, string lastName, int ID, string department)
        {
            this.department = department;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;
        }

        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public int GetID() { return ID; }
        public string GetDepartment() { return department; }
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

        public void SetDepartment(string department)
        {
            this.department = department;
        }

        public override string Report()
        {
            return "Role: Nurse, ID: " + this.ID + ", Name: " + this.firstName + " " + this.lastName + ", Specialty: " + this.department + "\n";
        }

        public override string DisplayDetails()
        {
            return "ID: " + this.ID + ", Name: " + this.firstName + " " + this.lastName + ", Specialty: " + this.department + "\n";
        }
    }
}
