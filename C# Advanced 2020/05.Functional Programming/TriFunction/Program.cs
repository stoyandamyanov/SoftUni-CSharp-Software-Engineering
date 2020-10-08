using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int Score = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            
            

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray()
                .Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr
                .FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, Score, isValidWord);
            Console.WriteLine(result);

        }

        

    }
}
