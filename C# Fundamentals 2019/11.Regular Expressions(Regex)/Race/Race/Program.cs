using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine()
            .Split(", ")
            .ToList();

            Dictionary<string, int> allNames = new Dictionary<string, int>();
            foreach (var item in inputNames)
            {
                allNames.Add(item, 0);
            }

            var regexName = @"[A-Za-z]";
            var regexKm = @"[0-9]";
            string input = Console.ReadLine();
            string fullName = "";

            int totalKm = 0;
            while (input != "end of race")
            {
                fullName = "";
                totalKm = 0;
                var name = Regex.Matches(input, regexName);
                var km = Regex.Matches(input, regexKm);

                foreach (Match N in name)
                {
                    fullName += N.Value;
                }
                foreach (Match digit in km)
                {
                    totalKm += int.Parse(digit.Value);
                }

                if (allNames.ContainsKey(fullName))
                {
                    allNames[fullName] += totalKm;
                }


                input = Console.ReadLine();
            }

            int i = 0;
            foreach (KeyValuePair<string, int> item in allNames.OrderByDescending(x => x.Value))
            {
                i++;
                string name = item.Key;
                if (i == 1)
                {
                    Console.WriteLine($"{i}st place: {name}");
                }
                else if(i == 2)
                {
                    Console.WriteLine($"{i}nd place: {name}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"{i}rd place: {name}");
                    break;
                }
            }

        }
    }
}
