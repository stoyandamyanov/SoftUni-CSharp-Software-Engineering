using System;
using System.Collections.Generic;
using System.Linq;

namespace TanksCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ownedTanks = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());
            
            int count = 0;
            while (count < n)
            {
                 
                List<string> command = Console.ReadLine()
                    .Split(", ")
                    .ToList();

                if (command[0] == "Add")
                {
                    string tankName = command[1];
                    if (ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        ownedTanks.Add(tankName);
                        Console.WriteLine("Tank successfully bought");
                    }
                }
                else if (command[0] == "Remove")
                {
                    
                    
                        string tankName = command[1];

                        if (ownedTanks.Contains(tankName))
                        {
                            ownedTanks.Remove(tankName);
                            Console.WriteLine("Tank successfully sold");
                        }
                        else
                        {
                            Console.WriteLine("Tank not found");
                        }
                    
                    
                }
                else if (command[0] == "Remove At") //if or else if
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index <= ownedTanks.Count - 1)
                    {
                        ownedTanks.RemoveAt(index);
                        Console.WriteLine($"Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string name = command[2];

                    if (index >= 0 && index <= ownedTanks.Count - 1)
                    {
                        if (ownedTanks.Contains(name))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            ownedTanks.Insert(index, name);
                            Console.WriteLine("Tank successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }

                }
                count++;
            }

            Console.WriteLine(string.Join(", ", ownedTanks ));
        }
    }
}
