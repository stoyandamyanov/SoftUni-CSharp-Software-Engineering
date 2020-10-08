using System;
using System.Linq;

namespace CustomMinFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToArray();

            Func<double[], double> minFunc = new Func<double[], double>(GetMin);

            var minNum = minFunc(numbers);

            Console.WriteLine(minNum);

            
        }
        static double GetMin(double[] numbers)
        {
            var min = double.MaxValue;

            foreach (var num in numbers)
            {
                if(num < min)
                {
                    min = num;
                }
            }

            return min;
        }

    }
}
