using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(\$|%)([A-Z][a-z]{2,})\1:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
            int totalCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            var correctInput = Regex.Matches(input, pattern);
               

            int counter = 0;

            while (true)
            {
                correctInput = Regex.Matches(input, pattern);

                if (!Regex.IsMatch(input,pattern))
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    
                    foreach (Match item in correctInput)
                    {
                        int char1 = int.Parse(item.Groups[3].Value);
                        int char2 = int.Parse(item.Groups[4].Value);
                        int char3 = int.Parse(item.Groups[5].Value);

                        Console.WriteLine($"{item.Groups[2]}: {(char)char1}{(char)char2}{(char)char3}");
                    }
                }
                counter++;
                if(counter == totalCount)
                {
                    break;
                }
                
                input = Console.ReadLine();
                
            }

        }
    }
}
