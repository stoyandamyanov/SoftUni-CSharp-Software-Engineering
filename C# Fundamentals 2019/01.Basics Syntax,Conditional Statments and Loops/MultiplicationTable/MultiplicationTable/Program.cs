using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times == 1)
            {
                Console.WriteLine($"{number} X 1 = {number * 1}");
                Console.WriteLine($"{number} X 2 = {number * 2}");
                Console.WriteLine($"{number} X 3 = {number * 3}");
                Console.WriteLine($"{number} X 4 = {number * 4}");
                Console.WriteLine($"{number} X 5 = {number * 5}");
                Console.WriteLine($"{number} X 6 = {number * 6}");
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 2)
            {
                
                Console.WriteLine($"{number} X 2 = {number * 2}");
                Console.WriteLine($"{number} X 3 = {number * 3}");
                Console.WriteLine($"{number} X 4 = {number * 4}");
                Console.WriteLine($"{number} X 5 = {number * 5}");
                Console.WriteLine($"{number} X 6 = {number * 6}");
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 3)
            { 
                Console.WriteLine($"{number} X 3 = {number * 3}");
                Console.WriteLine($"{number} X 4 = {number * 4}");
                Console.WriteLine($"{number} X 5 = {number * 5}");
                Console.WriteLine($"{number} X 6 = {number * 6}");
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 4)
            {
                
                Console.WriteLine($"{number} X 4 = {number * 4}");
                Console.WriteLine($"{number} X 5 = {number * 5}");
                Console.WriteLine($"{number} X 6 = {number * 6}");
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 5)
            {
                
                Console.WriteLine($"{number} X 5 = {number * 5}");
                Console.WriteLine($"{number} X 6 = {number * 6}");
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 6)
            {
               
                Console.WriteLine($"{number} X 6 = {number * 6}");
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 7)
            {
                
                Console.WriteLine($"{number} X 7 = {number * 7}");
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if (times == 8)
            {
                
                Console.WriteLine($"{number} X 8 = {number * 8}");
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 9)
            {
                
                Console.WriteLine($"{number} X 9 = {number * 9}");
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else if(times == 10)
            {
                Console.WriteLine($"{number} X 10 = {number * 10}");
            }
            else
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
        }
        
    }
}
