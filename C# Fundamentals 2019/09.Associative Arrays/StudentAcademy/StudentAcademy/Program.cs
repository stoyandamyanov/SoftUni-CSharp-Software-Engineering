using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var StudentsGrades = new Dictionary<string, List<double>>();

            List<double> grades = new List<double>();

            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            while (counter <= n)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!StudentsGrades.ContainsKey(name))
                {
                    StudentsGrades.Add(name, grades);
                    grades.Add(grade);

                    grades = new List<double>();

                }
                else
                {
                    StudentsGrades[name].Add(grade);
                }

                counter ++;
            }

            foreach (var student in StudentsGrades.OrderByDescending(x => x.Value.Average()))
            {
                
                if(student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
         
    }

}   

    




