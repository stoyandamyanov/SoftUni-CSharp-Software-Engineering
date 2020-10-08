using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);

            string[] command = Console.ReadLine()
                .ToLower()
                .Split();

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    int removedNumberscount = int.Parse(command[1]);
                    if (removedNumberscount > stack.Count)
                    {
                        command = Console.ReadLine()
                               .ToLower()
                               .Split();
                        continue;
                    }
                    for (int i = 0; i < removedNumberscount; i++)
                    {
                        stack.Pop();
                    }
                }
                else if (command[0] == "end")
                {
                    break;
                }

                command = Console.ReadLine()
                    .ToLower()
                    .Split();
            }

            int totalSum = stack.Sum();
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
