using System;

namespace concatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            bool isSpecial = true;
            for (int number = 1; number <= n; number++)
            {
                int Sumofdigits = 0;
                int digit = number;
                digit = number;
                while (digit > 0)
                {
                    
                    Sumofdigits += digit % 10;
                    digit = digit / 10;
                }
                isSpecial = (Sumofdigits == 5) || (Sumofdigits == 7) || (Sumofdigits == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                
                
            }

        }
    }
}
