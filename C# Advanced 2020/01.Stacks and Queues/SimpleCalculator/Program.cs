﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var values = input.Split();

            Stack<string> stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operatorr = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (operatorr)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(stack.Pop());

        }
    }
}
