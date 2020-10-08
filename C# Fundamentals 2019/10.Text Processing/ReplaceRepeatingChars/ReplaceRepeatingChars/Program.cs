using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        { 
            string text = Console.ReadLine();
            char previous =' ';
            List<char> result = new List<char>();
            
            for (int i = 0; i <= text.Length -1; i++)
            {
                previous = text[i];
                int index = text.IndexOf(previous);
                if(i == text.Length - 1)
                {
                    result.Add(previous);
                    break;
                }
                if (previous != text[i+1])
                {
                    result.Add(previous);
                }
            }

            Console.Write(string.Join("",result));
            Console.WriteLine();
            
        }

    }
}
