using System;

namespace AddandSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            AddtwoNumbersandSubstractbyThird(num1, num2, num3);
        }
        static void AddtwoNumbersandSubstractbyThird(int n1, int n2,int n3)
        {
            double result = 0;

            result = ((n1 + n2) - n3);
            Console.WriteLine($"{result}");
        }
        
    }
}
