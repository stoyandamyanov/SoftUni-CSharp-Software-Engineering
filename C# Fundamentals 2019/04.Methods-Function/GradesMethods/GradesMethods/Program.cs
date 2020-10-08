using System;

namespace GradesMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades(double.Parse(Console.ReadLine()));
        }

        static void Grades(double Grade)
        {
            if(Grade >= 2.00 && Grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if(Grade >= 3.00 && Grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if(Grade >= 3.50 && Grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if(Grade >= 4.50 && Grade <= 5.49)
            {
                Console.WriteLine("Very Good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
