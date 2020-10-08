using System;

namespace rectangleAreamethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            RectangleArea(width, height);
        }

        static void RectangleArea(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
