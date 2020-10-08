using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Sumofdigits = 0;
            for (int number = 1; number <= n; number++)
            {
                
                int digit = number;
                digit = number;
                while (digit > 0)
                {
                    
                    Sumofdigits += digit % 10;
                    digit = digit / 10;
                }
                Console.WriteLine(Sumofdigits);
            }
            
        }
    }
}
