using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse (Console.ReadLine());


            var uniqueElements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalElements = Console.ReadLine()
                    .Split();

                for (int j = 0; j < chemicalElements.Length; j++)
                {
                    
                    uniqueElements.Add(chemicalElements[j]);
                }

            }

            Console.WriteLine($"{string.Join(" ", uniqueElements.OrderBy(x => x))}");
        }
    }
}
