using System;

namespace Smallest_of_Three_methods_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            PrintSmallestNumber(numOne,numTwo,numThree);
            
        }

        static void PrintSmallestNumber(int a, int b, int c)
        {
            int num = 0;
            if(a < b && a < c)
            {
                num = a;
            }
            else if(b < a && b < c)
            {
                num = b;
            }
            else if(c < a && c < b)
            {
                num = c;
            }
            Console.WriteLine(num);
        }
    }
}
