using System;

namespace Methods
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Loops();
           
            
        }


        static void Loops()
        {
            int number =int.Parse(Console.ReadLine());
            for (int i = number; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        static void Specs(string Name, int age , double grade)
        {
            Name = Console.ReadLine();
            age =int.Parse(Console.ReadLine());
            grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Student: {Name} Age:{age} Grade:{grade}");
        }
    }
}
