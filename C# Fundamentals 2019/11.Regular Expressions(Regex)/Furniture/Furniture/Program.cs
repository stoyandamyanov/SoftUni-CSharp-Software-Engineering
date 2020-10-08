using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            double sum = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string Name = match.Groups[1].Value;
                    string name2 = match.Groups[2].Value;
                    Console.WriteLine(Name);
                    sum += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {sum:f2}");


        }
    }
}
