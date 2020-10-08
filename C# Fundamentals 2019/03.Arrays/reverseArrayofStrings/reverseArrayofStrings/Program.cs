using System;
using System.Linq;

namespace reverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]texts = Console.ReadLine().Split();
            string result = string.Join(" ",texts.Reverse());

            Console.WriteLine(result);
        }
    }
}
