using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> data = new List<string>();
                
            while (true)
            {
                string input = Console.ReadLine();

                data.Add(input);
                
                if(input == "stop")
                {
                    break;
                }
            }
            var dict = new Dictionary<string, int>();

            for (int i = 0; i <= data.Count - 1; i++)
            {
                
                if(data.IndexOf(data[i]) % 2 == 0 && data[i] != "stop")
                {
                    int value = int.Parse(data[i + 1]);
                    if (dict.ContainsKey(data[i]))
                    {
                        dict[data[i]] += value;
                    }
                    else
                    {
                        dict.Add(data[i], value);
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
