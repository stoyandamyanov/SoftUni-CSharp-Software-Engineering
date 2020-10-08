using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordTolower = word.ToLower();

                if(dict.ContainsKey(wordTolower))
                {
                    dict[wordTolower]++;
                }
                else
                {
                    dict.Add(wordTolower, 1);
                }
            }

            foreach (var count in dict)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
