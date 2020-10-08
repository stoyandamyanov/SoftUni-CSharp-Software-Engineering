using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums.Add(num);

            }

            Box<int> box = new Box<int>(nums);

            int[] indexesToSwap = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.Swap(nums, indexesToSwap[0], indexesToSwap[1]);
            Console.WriteLine(box);
        }
    }
}
