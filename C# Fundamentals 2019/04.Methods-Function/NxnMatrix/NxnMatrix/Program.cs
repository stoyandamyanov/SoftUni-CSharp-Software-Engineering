using System;

namespace NxnMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NxnMatrix(n);
        }

        static void NxnMatrix(int number)
        {
            for (int i = number; i > 0; i--)
            {
                Console.Write(number + " ");
                for (int j  = 1; j  <= number-1; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
