using System;
using System.Collections.Generic;
using System.Linq;

namespace FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                if(command[0] == "Join")
                {
                    string name = command[1];
                    frogs.Add(name);
                }
                else if(command[0] == "Jump")
                {
                    string name = command[1];
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < frogs.Count)
                    {
                        frogs.Insert(index, name);
                    }
                    else if(index >=0 && index == frogs.Count)
                    {
                        frogs.Insert(index - 1, name);
                    }
                }
                else if(command[0] == "Dive")
                {
                    int index = int.Parse(command[1]);

                    if(index >= 0 && index < frogs.Count)
                    {
                        frogs.RemoveAt(index);
                    }
                    else if(index >= 0 && index == frogs.Count)
                    {
                        frogs.RemoveAt(index - 1);
                    }
                }
                else if(command[0] == "First")
                {
                    int number = int.Parse(command[1]);
                    List<string> fromFirst = new List<string>();

                    if(number > 0 && number < frogs.Count)
                    {
                        for (int i = 0; i <= number; i++)
                        {
                            fromFirst.Add(frogs[i]);
                        }
                        Console.WriteLine(string.Join(" ",fromFirst));
                    }
                    else if(number >= frogs.Count)
                    {
                        Console.WriteLine(string.Join(" ",frogs));
                    }
                }
                else if(command[0] == "Last")
                {
                    int number = int.Parse(command[1]);
                    List<string> fromLast = new List<string>();

                    if(number > 0 && number < frogs.Count)
                    {
                        
                        for (int i = 1; i <= number; i++)
                        { 
                                fromLast.Add(frogs[frogs.Count-i]);
                        }
                        fromLast.Reverse();
                        Console.WriteLine(string.Join(" ", fromLast));
                    }
                    else if(number >= frogs.Count)
                    {
                       
                        Console.WriteLine(string.Join(" ", frogs));
                    }
                }
                else if(command[0] == "Print")
                {
                    if(command[1] == "Normal")
                    {
                        Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                        break;
                    }
                    else if(command[1] == "Reversed")
                    {
                        frogs.Reverse();
                        Console.WriteLine($"Frogs: {string.Join(" ",frogs)}");
                        break;
                    }
                }
            }
        }
    }
}
