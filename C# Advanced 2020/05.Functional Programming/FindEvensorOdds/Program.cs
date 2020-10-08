using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensorOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string query = Console.ReadLine();

            Predicate<int> pre = query == "odd" ? new Predicate<int>((n) => n % 2 != 0) :
                new Predicate<int>((n) => n % 2 == 0);

            List<int> nums = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if(pre(i))
                {
                    nums.Add(i);
                }
            }

            Console.WriteLine(string.Join(' ',nums));
        }

        
    }
}
