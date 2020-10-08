using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesLength = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> correctedOne = n => n.Length <= namesLength;
            

            var correctedNames = names.Where(correctedOne);

            foreach (var name in correctedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
