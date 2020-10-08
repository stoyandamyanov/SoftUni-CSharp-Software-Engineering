using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                totalSum += i;
                Console.Write(i + " ");
                
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
