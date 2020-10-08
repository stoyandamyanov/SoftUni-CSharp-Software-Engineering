using System;

namespace Sum_of_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(2 * i - 1);
                totalSum += 2 * i - 1;
            }

            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
