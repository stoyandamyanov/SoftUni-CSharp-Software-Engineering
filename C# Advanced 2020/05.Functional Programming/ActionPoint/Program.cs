using System;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                 .Split();

          Array.ForEach(names,Console.WriteLine);

        }
    }
}
