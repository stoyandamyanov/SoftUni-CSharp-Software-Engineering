using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                int n = int.Parse(command);

                PalindromeCheck(n);

                command = Console.ReadLine();
            }
        }

        static void PalindromeCheck(int a)
        {
            int reverse = 0;
            int last = 0;
            int startingNum = a;

            while (a != 0)
            {
                last = a % 10;
                reverse = reverse * 10 + last;
                a /= 10;
            }
            if(startingNum == reverse)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
