using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysExercise17._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condence array to number

              int[] numbersFirst = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            if(numbersFirst.Length == 1)
            {
                Console.WriteLine(numbersFirst[0]);
                return;
            }

            
            while (numbersFirst.Length > 1)
            {
                int[] condenced = new int[numbersFirst.Length - 1];
                for (int i = 0; i < numbersFirst.Length - 1; i++)
                {
                    condenced[i] = numbersFirst[i] + numbersFirst[i + 1];
                    
                    
                }
                numbersFirst = condenced;
            }
            
                Console.WriteLine(numbersFirst[0]);
            

        }
    }
}
