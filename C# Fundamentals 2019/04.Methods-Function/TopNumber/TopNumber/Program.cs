using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumber(n);
        }

        static void TopNumber(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                int totalSum = 0;
                bool oddDigit = false;
                int curent = i;
                while (true)
                {
                    if(curent == 0)
                    {
                        break;
                    }
                   
                    
                    int lastnum = curent % 10;
                    
                    totalSum += lastnum;
                    if(!(lastnum % 2 == 0))
                    {
                        oddDigit = true;
                    }

                    curent /= 10;
                }

                if ( totalSum % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
