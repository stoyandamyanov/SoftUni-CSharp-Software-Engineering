using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                wagons[i] = people;
                sum += wagons[i];
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(wagons[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}