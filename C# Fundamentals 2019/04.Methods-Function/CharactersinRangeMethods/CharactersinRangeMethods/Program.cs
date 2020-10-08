using System;

namespace CharactersinRangeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharactersinRange(first, second);
        }

        static void CharactersinRange (char a, char b)
        {
            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
            for (int j = b + 1; j < a; j++)
            {
                Console.Write((char)j + " ");
            }
            Console.WriteLine();
        }
    }
}
