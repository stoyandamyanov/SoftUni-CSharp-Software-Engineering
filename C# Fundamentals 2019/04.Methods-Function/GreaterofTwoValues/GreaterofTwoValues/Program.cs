using System;

namespace GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string Type = Console.ReadLine();

            GetMax(Type);
        }

        static void GetMax(string variable)
        {
            if(variable == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                

                if (a>b)
                {
                    Console.WriteLine(a);
                }
                else if(b > a)
                {
                    Console.WriteLine(b);
                }
            }
            else if(variable == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                if(a > b)
                {
                    Console.WriteLine(a);
                }
                else if(b > a)
                {
                    Console.WriteLine(b);
                }
            }
            else if(variable == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                int result = first.CompareTo(second);
                if(result < 0)
                {
                    Console.WriteLine(second);
                }
                else if(result > 0)
                {
                    Console.WriteLine(first);
                }
            }
        }
    }
}
