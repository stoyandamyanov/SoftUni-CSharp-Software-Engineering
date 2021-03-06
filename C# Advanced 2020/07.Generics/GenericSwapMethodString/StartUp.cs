﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);

            }

            Box<string> box = new Box<string>(names);

            int[] indexesToSwap = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.Swap(names, indexesToSwap[0], indexesToSwap[1]);
            Console.WriteLine(box);
        }
    }
}
