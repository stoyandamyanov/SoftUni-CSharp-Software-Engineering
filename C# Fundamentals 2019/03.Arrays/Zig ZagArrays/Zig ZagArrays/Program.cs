using System;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                if ((i + 1) % 2 != 0)
                {
                    arrOne[i] = nums[0];
                    arrTwo[i] = nums[1];
                }
                else
                {
                    arrOne[i] = nums[1];
                    arrTwo[i] = nums[0];
                }



            }
            string firstOutput = string.Join(" ", arrOne);
            string secondOutput = string.Join(" ", arrTwo);

            Console.WriteLine(firstOutput);
            Console.WriteLine(secondOutput);
        }
    }
}
