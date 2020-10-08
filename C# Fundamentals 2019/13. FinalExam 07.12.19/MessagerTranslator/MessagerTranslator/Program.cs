using System;
using System.Text.RegularExpressions;

namespace MessagerTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var patt = @"!([A-Za-z]{3,})!:\[([a-zA-z]{8,})\]";
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var current = Regex.Matches(input, patt);
            int counter = 0;

            while (true)
            {
                counter++;
                current = Regex.Matches(input, patt);

                if(!Regex.IsMatch(input,patt))
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    foreach (Match mess in current)
                    {
                        string command = mess.Groups[1].Value;
                        string message = mess.Groups[2].Value;
                        Console.Write($"{command}:" + " ");
                        for (int i = 0; i <= message.Length - 1; i++)
                        {
                            char ch = message[i];
                            int num = ch;
                            
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                    }
                }
                if(counter == count)
                {
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
