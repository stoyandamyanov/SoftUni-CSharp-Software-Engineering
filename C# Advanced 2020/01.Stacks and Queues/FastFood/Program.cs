using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            int remainingFood = totalFood;

            while (true)
            {
                if (remainingFood >= queue.Peek())
                {
                    remainingFood -= queue.Peek();
                    queue.Dequeue();
                    
                    if(queue.Count == 0)
                    {
                        Console.WriteLine(orders.Max());
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else if(remainingFood <= queue.Peek())
                {
                    Console.WriteLine(orders.Max());
                    Console.WriteLine($"Orders left: "+ string.Join(" ",queue));
                    break;
                }
            }
            
        }
    }
}
