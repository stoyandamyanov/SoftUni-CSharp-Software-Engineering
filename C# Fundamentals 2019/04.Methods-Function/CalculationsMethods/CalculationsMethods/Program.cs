using System;

namespace CalculationsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(Operation == "add")
            {
                Add(a, b);
            }
            else if(Operation == "substract")
            {
                Subtract(a, b);
            }
            else if(Operation == "multiply")
            {
                Multiply(a, b);
            }
            else if(Operation == "divide")
            {
                Divide(a, b);
            }
        }

        static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }

        static void Subtract(int a,int b)
        {
            Console.WriteLine(a-b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
}
