using System.Collections.Generic;

namespace P04_Hospital
{
    public class Doctor
    {
        private readonly List<Patient> patients;

        private Doctor()
        {
            this.patients = new List<Patient>();
        }
        public Doctor(string name, string surname)
            :this()
        {
            this.FirstName = name;
            this.SurName = surname;
        }
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string FullName => this.FirstName + this.SurName;

        public IReadOnlyCollection<Patient> Patients =>
            this.patients;

        public void AddPatientToDoctor(Patient patient)
        {
            this.patients.Add(patient);
        }
    }
}
