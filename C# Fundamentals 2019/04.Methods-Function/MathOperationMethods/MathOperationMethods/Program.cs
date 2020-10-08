using System;

namespace MathOperationMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Calculate(num1, symbol, num2);
        }

        static void Calculate(int a,char sym,int b)
        {
            double result = 0;
            if(sym == '/')
            {
                result = a / b;
                Console.WriteLine($"{result:f2}");
            }
            else if(sym == '*')
            {
                result = a * b;
                Console.WriteLine($"{result:f2}");
            }
            else if(sym == '+')
            {
                result = a + b;
                Console.WriteLine($"{result:f2}");
            }
            else if(sym == '-')
            {
                result = a - b;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
