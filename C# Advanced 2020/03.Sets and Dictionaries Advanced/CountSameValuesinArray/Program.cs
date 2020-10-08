using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();

            var counts = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if(counts.ContainsKey(num))
                {
                    counts[num] += 1;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
