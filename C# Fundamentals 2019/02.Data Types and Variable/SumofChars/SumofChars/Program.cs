using System;

namespace SumofChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <= n; i++)
            {
                char n1 = char.Parse(Console.ReadLine());
                totalSum += (int)n1;

                
            }
            Console.WriteLine($"The Sum equals: {totalSum}");
        }
    }
}
