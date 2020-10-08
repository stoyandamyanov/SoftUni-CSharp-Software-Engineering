using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumFirst = 0;
            int sumReverse = 0;


            for (int i = 0; i < arrInput.Length; i++)
            {
                sumReverse = 0;
                sumFirst += arrInput[i];
                for (int j = 0; j < arrInput.Length - i; j++)
                {
                    var currentEl = arrInput[arrInput.Length - 1 - j];
                    sumReverse += currentEl;
                }

                if (sumFirst == sumReverse)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
