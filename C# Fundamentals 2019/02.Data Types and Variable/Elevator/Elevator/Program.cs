using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalP = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Ceiling((double)totalP/capacity)}");
        }
    }
}
