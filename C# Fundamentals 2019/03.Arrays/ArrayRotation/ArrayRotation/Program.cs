﻿using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string firstNum = arr[0];
                for (int index = 1; index < arr.Length; index++)
                {
                    string currentE = arr[index];
                    arr[index - 1] = currentE;
                }

                arr[arr.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
