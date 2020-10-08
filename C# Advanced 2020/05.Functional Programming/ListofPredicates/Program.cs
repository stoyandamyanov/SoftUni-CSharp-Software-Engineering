using System;
using System.Collections.Generic;
using System.Linq;

namespace ListofPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endIndex = int.Parse(Console.ReadLine());

            int[] divisors = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> AllNums = new List<int>();

            

            for (int i = 1; i <= endIndex; i++)
            {
                bool isDivisible = true;

                foreach (var d in divisors)
                {
                    Predicate<int> isNotDivisor = x => i % x != 0;

                    if (isNotDivisor(d))
                    {
                        isDivisible = false;
                        break;
                    }

                }
                if(isDivisible)
                {
                    AllNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(' ',AllNums));
        }
    }
}
