using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Factorials(n1, n2);

        }

        static void Factorials(int a, int b)
        {
            double resultFactorialA = 1;
            double resultFactorialB = 1;
            double FinalResult = 0;
            for (int i = 1; i <= a; i++)
            {
                resultFactorialA *= i;

            }
            for (int j = 1; j <= b; j++)
            {
                resultFactorialB *= j;
            }
            FinalResult = resultFactorialA / resultFactorialB;
            Console.WriteLine($"{FinalResult:f2}");
        }
    }
}