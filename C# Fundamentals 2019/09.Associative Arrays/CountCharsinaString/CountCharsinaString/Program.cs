using System;
using System.Collections.Generic;

namespace CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray(); 

            var dict = new Dictionary<char, int>();

            foreach (char item in word)
            {
                char n = item;
                if(dict.ContainsKey(item))
                {
                    dict[n]++;
                }
                
                else if(item != ' ')
                {
                    dict.Add(n,1);

                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
