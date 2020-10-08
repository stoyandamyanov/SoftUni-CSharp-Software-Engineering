using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger F = 1;

            for (int i = 2; i <= n; i++)
            {
                F = F * i;
            }
            Console.WriteLine(F);
        }
    }
}
