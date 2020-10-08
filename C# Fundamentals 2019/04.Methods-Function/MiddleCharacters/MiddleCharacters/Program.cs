using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleChar(word);
        }

        static void MiddleChar(string a)
        {
            int MidCharIndex = a.Length / 2;
            if (a.Length % 2 != 0)
            {
                Console.WriteLine(a.Substring(MidCharIndex, 1));
            }
            else
            {
                Console.WriteLine(a.Substring(MidCharIndex - 1, 2));
            }
        }
    }
}
