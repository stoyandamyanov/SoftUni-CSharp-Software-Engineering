﻿using System;

namespace GenericBoxofIntegers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));

                Console.WriteLine(box);
            }
        }
    }
}
