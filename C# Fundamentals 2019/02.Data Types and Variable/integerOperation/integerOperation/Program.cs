﻿using System;

namespace integerOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int n1n2 = n1 + n2;
            int dividebythird = n1n2 / n3;
            int total = dividebythird * n4;

            Console.WriteLine(total);
        }
    }
}
