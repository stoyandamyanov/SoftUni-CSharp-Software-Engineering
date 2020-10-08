using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseandExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
                

            

            int N = int.Parse(Console.ReadLine());

            Func<int, bool> finalRes = n => n % N != 0;

            var numbers = nums.Reverse().Where(finalRes);

            Console.WriteLine(string.Join(' ',numbers));
        }    
    }
}
