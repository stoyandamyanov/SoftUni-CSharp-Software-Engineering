using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNummber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=^|\s)\+\d{3}(?<delimiter>[-|\s])2\k<delimiter>\d{3}\k<delimiter>\d{4}\b";
            var phones = Console.ReadLine();

            var totalMatches = Regex.Matches(phones, pattern);

            var MatchesPhones = totalMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            
            if(totalMatches.Count != 0)
            {
                Console.WriteLine(string.Join(", ", totalMatches));
            }
           
        }
        
    }
}
