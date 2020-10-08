using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var total = new SortedDictionary<char, int>();
            char currentCH = ' ';
            int count = 0;
            foreach (var ch in text)
            {
                currentCH = ch;
                count = text.Count(x => x == currentCH);
                if (!total.ContainsKey(currentCH))
                {
                    total.Add(currentCH, count);
                }

            }

            foreach (var item in total)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
