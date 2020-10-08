using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int addCount = input[0];
            int removeCount = input[1];
            string searchedNum = input[2].ToString();

            string[]allNums = Console.ReadLine()
                .Split();

            Queue<string> finalNums = new Queue<string>(allNums);

            for (int i = 1; i <= removeCount; i++)
            {
                finalNums.Dequeue();
            }

            if(finalNums.Contains(searchedNum))
            {
                Console.WriteLine("true");
            }
            else if(!finalNums.Contains(searchedNum) && finalNums.Count >= 1)
            {
                Console.WriteLine(finalNums.Min());
            }
            
            if(finalNums.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
