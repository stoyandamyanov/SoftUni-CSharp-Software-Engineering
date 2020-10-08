using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n)
                .ToArray();

            for (int i = 0; i < 3; i++)
            {
                if(i == numbers.Length)
                {
                    break;
                }
                Console.Write(sorted[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
