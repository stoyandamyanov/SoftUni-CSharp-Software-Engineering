using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            var coursesRegister = new Dictionary<string, List<string>>();

            var students = new List<string>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" : ");

                string courseName = input[0];
                string student = "";

                if (courseName == "end")
                {
                    break;
                }
                else if (!coursesRegister.ContainsKey(courseName))
                {
                    student = input[1];

                    coursesRegister.Add(courseName, students);
                    students.Add(student);

                    students = new List<string>();
                }
                else
                {
                    student = input[1];

                    coursesRegister[courseName].Add(student);
                }


                


            }

            foreach (var course in coursesRegister.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
