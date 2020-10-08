using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            List<int> final = new List<int>();

            for (int i = 1; i <= numbers.Length; i++)
            {
                if (queue.Peek() % 2 == 0)
                {
                    int current = queue.Peek();

                    final.Add(current);
                    queue.Dequeue();
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", final));
            
            
        }
    }
}
