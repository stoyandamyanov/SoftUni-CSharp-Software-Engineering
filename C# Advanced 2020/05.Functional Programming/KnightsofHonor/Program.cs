using System;
using System.Linq;

namespace KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honor = new Action<string>((name) =>
            {
                Console.WriteLine("Sir " + name);
            });

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(honor);
        }
    }
}
