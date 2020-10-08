using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Engine
    {
        private readonly List<Department> departments;
        private readonly List<Doctor> doctors;

        public Engine()
        {
            this.departments = new List<Department>();
            this.doctors = new List<Doctor>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] input = command.Split();
                string departamentName = input[0];
                string dFirstName = input[1];
                string dSurName = input[2];
                string patientName = input[3];
                string dfullname = dFirstName + dSurName;


                if (!this.DoctorExists(dfullname))
                {
                    doctors.Add(new Doctor(dFirstName, dSurName));
                }
                if (!this.DepartmentExists(departamentName))
                {
                    this.departments.Add(new Department(departamentName));
                }

                Department department = this.departments
                    .FirstOrDefault(d => d.Name == departamentName);

                Doctor doctor = this.doctors.FirstOrDefault(d => d.FullName == dfullname);

                bool IsFree = department.Rooms.Any(r => r.Count < 3);

                if (IsFree)
                {
                    Room firstFreeRoom = department.GetFirstFreeRoom();

                    Patient patient = new Patient(patientName);

                    firstFreeRoom.AddPatient(patient);

                    doctor.AddPatientToDoctor(patient);
                }

                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Room[] rooms = (Room[])departments.FirstOrDefault(d => d.Name == command)
                        .Rooms;

                    foreach (var room in rooms)
                    {
                        Console.WriteLine(room);
                    }       
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int roomNum))
                {
                    Room room = this.departments
                         .FirstOrDefault(d => d.Name == command)
                         .Rooms
                         .FirstOrDefault(r => r.Number == roomNum);

                    Console.WriteLine(room);
                }
                else
                {
                    
                }
                command = Console.ReadLine();
            }
        }

        private bool DoctorExists(string fullname) => doctors.Any(d => d.FullName == fullname);

        private bool DepartmentExists(string name)
        {
            bool exists = this.departments.Any(d => d.Name == name);

            return exists;
        }
    }
}
