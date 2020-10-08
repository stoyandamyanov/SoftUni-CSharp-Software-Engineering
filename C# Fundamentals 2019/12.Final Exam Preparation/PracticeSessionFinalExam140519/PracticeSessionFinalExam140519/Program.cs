using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSessionFinalExam140519
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("->");

            Dictionary<string, List<string>> roadsandDrivers = new Dictionary<string, List<string>>();

            while (input[0] !="END")
            {
                if(input[0] == "Add")
                {
                    string road = input[1];
                    string racerName = input[2];
                    if(!roadsandDrivers.ContainsKey(road))
                    {
                        roadsandDrivers.Add(road, new List<string>());
                        roadsandDrivers[road].Add(racerName);
                    }
                    else
                    {
                        roadsandDrivers[road].Add(racerName);
                    }
                }
                else if(input[0] == "Move")
                {
                    string currentRoad = input[1];
                    string racer = input[2];
                    string nextRoad = input[3];
                    if(roadsandDrivers[currentRoad].Contains(racer))
                    {
                        roadsandDrivers[nextRoad].Add(racer);
                        roadsandDrivers[currentRoad].Remove(racer);
                    }
                }
                else if(input[0] == "Close")
                {
                    string road = input[1];
                    roadsandDrivers.Remove(road);
                }

                input = Console.ReadLine()
                    .Split("->");
            }
            Console.WriteLine("Practice session:");
            foreach (var racer in roadsandDrivers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(racer.Key);
                Console.WriteLine(string.Join("\n",racer.Value.Select(s => "++"+ s)));
            }
        }
    }
}
