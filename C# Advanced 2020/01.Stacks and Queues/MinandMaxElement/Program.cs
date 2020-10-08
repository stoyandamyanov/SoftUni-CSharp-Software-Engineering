using System;
using System.Collections.Generic;
using System.Linq;

namespace MinandMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int counter = 0;

            Stack<int> stack = new Stack<int>();

            while (counter != N)
            {
                counter++;
                string[] command = Console.ReadLine()
                    .Split();
                string comm = command[0];

                if (comm == "1")
                {
                    int element = int.Parse(command[1]);
                    stack.Push(element);
                }
                else if (comm == "2")
                {
                    if(stack.Count == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                }
                else if (comm == "3")
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        int MaxValue = stack.Max();
                        Console.WriteLine(MaxValue);
                    }
                }
                else if (comm == "4")
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        int MinValue = stack.Min();
                        Console.WriteLine(MinValue);
                    }
                }

            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
