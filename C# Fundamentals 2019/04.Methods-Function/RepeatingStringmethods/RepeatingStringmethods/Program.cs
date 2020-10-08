using System;

namespace RepeatingStringmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            Repeat(value, counter);
        }

        static void Repeat(string one,int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.Write(one);
            }
            Console.WriteLine();
        }
    }
}
