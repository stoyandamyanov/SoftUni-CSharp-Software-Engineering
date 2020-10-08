using System;
using System.Linq;

namespace MagicSumArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(currentNum + numbers[j] == sum)
                    {
                        Console.WriteLine(currentNum + " " + numbers[j]);
                    }
                }
            }

        }
    }
}
