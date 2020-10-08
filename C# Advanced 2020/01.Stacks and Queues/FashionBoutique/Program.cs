using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersClothes = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int RackCapacity = int.Parse(Console.ReadLine());
            int RacksCounter = 0;
            Stack<int> stack = new Stack<int>(numbersClothes);
            int startedCapacity = RackCapacity;
            while (stack.Count != 0)
            {
                int current = stack.Pop();
                if(current > RackCapacity)
                {
                    RacksCounter++;
                    RackCapacity = startedCapacity;
                }
                RackCapacity -= current;
                if(RackCapacity == 0)
                {
                    RacksCounter++;
                    RackCapacity = startedCapacity;
                }
                if(stack.Count == 0 && RackCapacity < startedCapacity)
                {
                   RacksCounter++;
                }
            }
            Console.WriteLine(RacksCounter);
        }
    }
}
