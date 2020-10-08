using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char chh = word[i];
                int ch = chh + 3;
                char newch = (char)ch;

                Console.Write($"{newch}");
            }
            Console.WriteLine();
        }
    }
}
