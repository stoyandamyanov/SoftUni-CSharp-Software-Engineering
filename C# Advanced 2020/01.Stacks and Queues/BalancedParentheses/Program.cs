﻿using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var parantheses = Console.ReadLine()
                 .Trim()
                 .ToCharArray();

            var stack = new Stack<char>();
            var parenthesesPair = new Dictionary<char, char>();
            parenthesesPair['{'] = '}';
            parenthesesPair['['] = ']';
            parenthesesPair['('] = ')';

            if (parantheses.Length % 2 != 0 || parantheses.Length == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var p in parantheses)
            {
                //open parantheses
                if (parenthesesPair.ContainsKey(p))
                {
                    stack.Push(p);
                }
                else
                {
                    var openParantheses = stack.Pop();
                    if (parenthesesPair[openParantheses] != p)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");

        }
    }
}
