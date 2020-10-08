using System;

namespace Special_numbers___dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int num = 1; num <= n; num++)
            {
                int sumofDigits = 0;
                int digits = num;
                while(digits > 0)
                {
                    sumofDigits += digits % 10;
                    digits = digits / 10;
                }

                if(sumofDigits == 5 || sumofDigits == 7 || sumofDigits == 11)
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }

            }
        }
    }
}
