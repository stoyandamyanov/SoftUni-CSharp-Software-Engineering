using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine()
                .Split(" ");

            int number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children);

            int currentIndex = 1;
            while (queue.Count > 1)
            {
                var currentName = queue.Dequeue();
                if (currentIndex == number)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currentIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentName);
                }

                currentIndex++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
