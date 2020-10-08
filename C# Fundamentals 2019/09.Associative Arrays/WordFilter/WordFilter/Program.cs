using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            for (int i = 0; i <= words.Length-1; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
