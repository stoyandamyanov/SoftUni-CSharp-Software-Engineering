﻿using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = (arr) =>
            {
                Console.WriteLine(string.Join(" ",arr));
            };
            
            
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if(input == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int[], int[]> processor = GetProcessor(input);

                    numbers = processor(numbers);
                }
            }
        }

        static Func<int[], int[]> GetProcessor(string input)
        {
            Func<int[], int[]> processor = null;

            if (input == "add")
            {
                processor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]++;
                    }
                    return arr;
                });
            }
            else if (input == "multiply")
            {
                processor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] *= 2;
                    }
                    return arr;
                });
            }
            else if (input == "subtract")
            {
                processor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }
                    return arr;
                });
            }

            return processor;
        }
    }
}
