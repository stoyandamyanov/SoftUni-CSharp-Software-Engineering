using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] SpecNumberandPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = SpecNumberandPower[0];
            int Power = SpecNumberandPower[1];


            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];

                if(target == bombNumber)
                {
                    BombNumbers(numbers, Power, i);
                }
            }
            Console.WriteLine(numbers.Sum());

        }

        static void BombNumbers(List<int> numbers, int power, int i)
        {
            int start = Math.Max(0, i - power);
            int end = Math.Min(numbers.Count - 1, i + power);

            for (int j = start; j <= end; j++)
            {
                numbers[j] = 0;
            }
        }
    }
}
