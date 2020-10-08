using System;

namespace MathPowermethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            MathPower(number,power);
        }

        static void MathPower(double a,double b)
        {
            double total = Math.Pow(a, b);
            Console.WriteLine(total);
        }
    }
}
