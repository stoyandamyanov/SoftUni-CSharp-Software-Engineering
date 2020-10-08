using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            Random rnd = new Random();
            var wordsCount = words.Length;
            for (int i = 0; i < words.Length - 1; i++)
            {
                int k = rnd.Next(0, words.Length);
                string randomEl = words[k];
                string el = words[i];
                words[k] = el;
                words[i] = randomEl;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
