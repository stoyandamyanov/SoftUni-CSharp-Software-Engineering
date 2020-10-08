using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOne = Console.ReadLine();
            int numTwo = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int temp = 0;

            foreach (char ch in numOne.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * numTwo + temp;
                int resultD = result % 10;

                sb.Insert(0, resultD);
                temp = result / 10;

            }
            if (temp > 0)
            {
                sb.Insert(0, temp);
            }

            string finalNumber = sb.ToString().TrimStart('0');

            if (finalNumber.Length == 0)
            {
                finalNumber = "0";
            }

            Console.WriteLine(finalNumber);
        }
    }
}
