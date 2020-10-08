using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NM = (Console.ReadLine())
                .Split(" ")
                .ToArray();

            int firstNum = int.Parse(NM[0]);
            int secondNum = int.Parse(NM[1]);

           
            int counter = 0;

            int value = int.Parse(Console.ReadLine());
           
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var allDiff = new HashSet<int>();
            
            while (counter < firstNum)
            {
                counter++;

                firstSet.Add(value);
                
                value = int.Parse(Console.ReadLine());
            }
            counter = 0;

            while (counter != secondNum)
            {
                counter++;
                secondSet.Add(value);

                if (counter == secondNum)
                {
                    break;
                }

                value = int.Parse(Console.ReadLine());
            }
            foreach (var num in firstSet)
            {
                if(secondSet.Contains(num))
                {
                    allDiff.Add(num);
                }
            }

            Console.WriteLine($"{string.Join(" ",allDiff)}");
        }
    }
}
