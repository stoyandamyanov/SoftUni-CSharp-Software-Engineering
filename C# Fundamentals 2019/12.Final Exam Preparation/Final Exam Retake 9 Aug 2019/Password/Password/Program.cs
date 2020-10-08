using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var patt = @"^(.+)>([\d]{3,3})\|([a-z]{3,3})\|([A-Z]{3,3})\|([^<>]{3,3})<\1$";
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;
            var correct = Regex.Matches(input, patt);

            while (true)
            {
                count++;
                correct = Regex.Matches(input, patt);
                if (!Regex.IsMatch(input, patt))
                {
                    Console.WriteLine("Try another password!");
                }
                else
                {
                    foreach (Match pass in correct)
                    {
                        string first = pass.Groups[2].Value;
                        string second = pass.Groups[3].Value;
                        string third = pass.Groups[4].Value;
                        string fourt = pass.Groups[5].Value;

                        Console.WriteLine($"Password: {first}{second}{third}{fourt}");
                    }

                }

                if(count == n)
                {
                    break;
                }


                input = Console.ReadLine();
            }
        }
    }
}
