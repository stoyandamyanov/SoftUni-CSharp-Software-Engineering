using System;
using System.Text.RegularExpressions;

namespace TheIsleofManTTRace140519finalexam
{
    class Program
    {
        static void Main(string[] args)
        {
            var patt = @"([$#%*&])([A-za-z]+)\1=(\d+)!!(.+)";
            string input = Console.ReadLine();

            var correctOne = Regex.Matches(input, patt);
            string Encrypted = "";
            int lenghtofGeohash = 0;
            
            while (true)
            {
                correctOne = Regex.Matches(input, patt);

                if (!Regex.IsMatch(input, patt))
                {
                    Console.WriteLine("Nothing found!");
                }
                else
                {

                    foreach (Match N in correctOne)
                    {
                        string RacerName = N.Groups[2].Value;
                        lenghtofGeohash = int.Parse(N.Groups[3].Value);
                        string DecryptedCode = N.Groups[4].Value;

                        if (lenghtofGeohash != DecryptedCode.Length)
                        {
                            Console.WriteLine("Nothing found!");
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i <= DecryptedCode.Length - 1; i++)
                            {
                                int ch = DecryptedCode[i] + lenghtofGeohash;
                                Encrypted += (char)ch;
                            }
                            Console.WriteLine($"Coordinates found! {RacerName} -> {Encrypted}");

                            break;
                        }
                        
                    }
                    if(lenghtofGeohash == Encrypted.Length)
                    {
                        break;
                    }
                }


                input = Console.ReadLine();
            }
        }
    }
}
