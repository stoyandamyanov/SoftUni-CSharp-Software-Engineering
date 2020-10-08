using System;

namespace RhombusofStars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int stCount = 1; stCount <= size; stCount++)

                PrintRow(size, stCount);

            for (int stCount = size - 1; stCount >= 1; stCount--)

                PrintRow(size, stCount);


        }

        static void PrintRow(int size,int stCount)
        {
            for (int i = 0; i < size - stCount; i++)

                Console.Write(" ");

            for (int col = 1; col < stCount; col++)

                Console.Write("* ");

            Console.WriteLine("*");
        }
    }
}
