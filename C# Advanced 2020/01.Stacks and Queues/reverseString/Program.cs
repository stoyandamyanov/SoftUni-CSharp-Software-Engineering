using System;
using System.Collections.Generic;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
