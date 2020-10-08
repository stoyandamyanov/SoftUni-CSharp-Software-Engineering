using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int savedNumber = number;
            int factorial = 1;
            int Sum = 0;

            while (number != 0)
            {
                int digit = number % 10;

                factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                    

                }
                Sum += factorial;
                number /= 10;
            }
            if(Sum == savedNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
