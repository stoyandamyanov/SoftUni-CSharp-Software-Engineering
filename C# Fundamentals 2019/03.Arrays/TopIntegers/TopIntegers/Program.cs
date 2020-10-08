using System;
using System.Collections.Generic;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int>finalArr = new List<int>();

            for (int i = 0; i < newArr.Length; i++)
            {
                bool Isbigger = true;
                for (int j = i+1; j < newArr.Length; j++)
                {
                    if(newArr[i] <= newArr[j])
                    {
                        Isbigger = false;
                    }
                   
                }
                if (Isbigger)
                {
                    finalArr.Add(newArr[i]);
                }


            }

            Console.WriteLine(string.Join(" ", finalArr));
        }
    }
}
