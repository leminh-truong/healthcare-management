using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class Medical_Record
    {
        private int ID;
        private int patientID;
        private int doctorID;
        private string diagnosis = "";
        private string treatment = "";
        public Medical_Record() 
        {
        }

        public void SetID(int ID) {this.ID = ID;}
        public int GetID() {return ID;}
        public void SetPatientID(int PatientID) {this.patientID = PatientID;}
        public int GetPatientID() { return patientID; }

        public void SetDoctorID(int doctorID) { this.doctorID = doctorID;}
        public int GetDoctorID() { return doctorID; }
        public void SetDiagnosis(string diagnosis) { this.diagnosis = diagnosis;}
        public string GetDiagnosis() { return diagnosis;}

        public void SetTreatment(string treatment) { this.treatment = treatment;}
        public string GetTreatment() { return treatment;}

        public string Report()
        {
            return "Record ID: " + this.ID + ", Doctor ID: " + this.doctorID + ", Patient ID: " + this.patientID + "\nDiagnosis: " + this.diagnosis + "\nTreatment: " + this.treatment + "\n";
        }
        public string DisplayDetails()
        {
            return "Record ID: " + this.ID + ", Doctor ID: " + this.doctorID + "\nDiagnosis: " + this.diagnosis + "\nTreatment: " + this.treatment;
        }
    }
}
