using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");

            bool result = true;
            for (int i = 0; i <= input.Length-1; i++)
            {
                string word = input[i];

                if (word.Length >= 3 && word.Length <= 16)
                {
                    if (result = word.All(c => Char.IsLetterOrDigit(c) || c == '_' || c == '-'))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
