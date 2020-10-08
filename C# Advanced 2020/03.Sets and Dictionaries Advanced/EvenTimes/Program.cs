using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());

            var allNums = new Dictionary<int,int>();
            int count = 0;
            int totaltimes = 0;
            while (true)
            {
                count++;
                if (!allNums.ContainsKey(number))
                {
                    allNums.Add(number, 1);
                }
                else
                {
                    allNums[number]++;
                }


                if(count == n)
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }

            foreach (var num in allNums)
            {
                if(num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    break;
                }
            }
            
        }
    }
}
