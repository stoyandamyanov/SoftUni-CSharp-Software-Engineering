using System;
using System.Text.RegularExpressions;

namespace SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var correctCliets = @"%([A-Z][a-z]+)%[^|%$.]*<(\w+)>[^|%$.]*\|(\d+)\|[^|%$.0-9]*(\d+.?\d+)\$";

            string input = Console.ReadLine();
            double totalSum = 0;
            double totalSumperCLIENT = 0;
            while (input != "end of shift")
            {
                var Client = Regex.Matches(input, correctCliets);

                foreach (Match cli in Client)
                {
                    string ClientName = cli.Groups[1].Value;
                    string Product = cli.Groups[2].Value;
                    int quantity = int.Parse(cli.Groups[3].Value);
                    double price = double.Parse(cli.Groups[4].Value);

                    totalSumperCLIENT = quantity * price;
                    totalSum += totalSumperCLIENT;
                    Console.WriteLine($"{ClientName}: {Product} - {totalSumperCLIENT:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
