using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] student = Console.ReadLine()
                .Split();

            var averageGrade = new Dictionary<string, List<decimal>>();
            int count = 0;

            while(true)
            {
                count++;
                string name = student[0];
                decimal grade = decimal.Parse(student[1]);
                
                if(!averageGrade.ContainsKey(name))
                {
                    averageGrade.Add(name, new List<decimal>());
                    
                }
                    averageGrade[name].Add(grade);
                
                if(count == n)
                {
                    break;
                }

                student = Console.ReadLine()
                    .Split();
            }

            foreach (var (nameKey,gradeValues) in averageGrade)
            {
                Console.Write($"{nameKey} -> ");

                foreach (var gradeValue in gradeValues)
                {
                    Console.Write($"{gradeValue:f2} ");
                }
                Console.Write($"(Avg: {gradeValues.Average():f2})");
                Console.WriteLine();
            }

        }
    }
}
