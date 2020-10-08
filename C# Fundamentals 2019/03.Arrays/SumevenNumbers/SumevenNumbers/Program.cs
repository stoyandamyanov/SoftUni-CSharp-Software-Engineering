using System;
using System.Linq;

namespace SumevenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int EvenSum = 0;
            int OddSum = 0;

            foreach (int i in numbers)
            {
               if(i % 2 == 0)
                {
                    EvenSum += i;
                }
               else
                {
                    OddSum += i;
                }
            }
            Console.WriteLine(EvenSum-OddSum);
        }
    }
}
