using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[]input = Console.ReadLine()
                    .Split(" -> ",StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] clothes = input[1]
                    .Split(',',StringSplitOptions.RemoveEmptyEntries);

                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();

                }

                foreach (var cloth in clothes)
                {
                   if(!wardrobe[color].ContainsKey(cloth))
                   {
                        wardrobe[color][cloth] = 0;
                   }

                    wardrobe[color][cloth]++;
                }
            }

            string[] searchedCloth = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string colorS = searchedCloth[0];
            string clothS = searchedCloth[1];

            foreach (var cdp in wardrobe)
            {
                string color = cdp.Key;
                Dictionary<string, int> clothes = cdp.Value;


                Console.WriteLine($"{color} clothes:");

                foreach (var cqp in clothes)
                {
                    string cloth = cqp.Key;
                    int qty = cqp.Value;

                    if(color == colorS && cloth == clothS)
                    {
                        Console.WriteLine($"* {cloth} - {qty} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {qty}");
                    }
                }
            }
        }
    }
}
