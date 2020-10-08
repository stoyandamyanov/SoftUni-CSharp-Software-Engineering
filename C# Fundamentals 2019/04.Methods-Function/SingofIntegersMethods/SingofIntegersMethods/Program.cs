using System;

namespace SingofIntegersMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sign(int.Parse(Console.ReadLine()));
        }

        static void Sign(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if(num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
