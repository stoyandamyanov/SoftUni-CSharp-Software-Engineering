using System;
using System.Text.RegularExpressions;

namespace MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string patt = @"([*@])([A-Z][a-z]{2,})\1\:\s\[([a-zA-Z])\]\|\[([a-zA-Z])\]\|\[([a-zA-Z])\]\|$";
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var Valid = Regex.Matches(input, patt);
            int count = 0;

            while (true)
            {
                Valid = Regex.Matches(input, patt);

                if (!Regex.IsMatch(input,patt))
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    foreach (Match item in Valid)
                    {
                        string tag = item.Groups[2].Value;
                        char num1 = char.Parse(item.Groups[3].Value);
                        char num2 = char.Parse(item.Groups[4].Value);
                        char num3 = char.Parse(item.Groups[5].Value);

                        Console.WriteLine($"{tag}: {(int)num1} {(int)num2} {(int)num3}");
                    }
                }


                count++;
                if(count == n)
                {
                    break;
                }
                input = Console.ReadLine();

            }

        }
    }
}
