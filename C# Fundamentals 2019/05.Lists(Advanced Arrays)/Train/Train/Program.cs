using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string line;

            while((line=Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split(' ');

                if(tokens.Length == 1)
                {
                    int pasengers = int.Parse(tokens[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if(train[i] + pasengers <= maxCapacity)
                        {
                            train[i] += pasengers;
                            break;
                        }
                    }
                }
                else
                {
                    int passengers = int.Parse(tokens[1]);
                    train.Add(passengers);
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
