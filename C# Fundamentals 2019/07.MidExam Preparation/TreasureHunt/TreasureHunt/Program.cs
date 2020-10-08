using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> TreasureChest = Console.ReadLine().Split("|")
                .ToList();

            

            while (true)
            {
                List<string> command = Console.ReadLine()
                .Split()
                .ToList();
                if (command[0] == "Loot")
                {
                    for (int i = 1; i < command.Count; i++)
                    {
                        if(TreasureChest.Contains(command[i]))
                        {
                            
                        }
                        else
                        {
                            TreasureChest.Insert(0, command[i]);
                        }
                    }
                            
                        
                    
                }
                else if(command[0] == "Drop")
                {

                    int index = int.Parse(command[1]);
                    if (index < 0)
                    {
                        continue;
                    }
                    else if (index >= 0 & index < TreasureChest.Count)
                    {
                        TreasureChest.Add(TreasureChest[index]);
                        TreasureChest.RemoveAt(index);
                    }

                   
                }
                else if(command[0] == "Steal")
                {
                    int stealedItems = int.Parse(command[1]);

                    List<string> StolenItems = new List<string>();

                    if(stealedItems < 0)
                    {
                        continue;
                    }
                    if(stealedItems > TreasureChest.Count)
                    {
                        stealedItems = TreasureChest.Count;
                        for (int i = 0; i < stealedItems; i++)
                        {
                            StolenItems.Add(TreasureChest[TreasureChest.Count - 1]);
                            TreasureChest.RemoveAt(TreasureChest.Count - 1);
                        }
                        StolenItems.Reverse();
                        Console.WriteLine(string.Join("," + " ", StolenItems));
                    }
                    else
                    {
                        for (int i = 0; i < stealedItems; i++)
                        {
                            StolenItems.Insert(0, TreasureChest[TreasureChest.Count- 1]);
                            TreasureChest.RemoveAt(TreasureChest.Count - 1);
                        }

                        Console.WriteLine(string.Join(","+" ", StolenItems));
                    }
                }

                if (command[0] == "Yohoho!")
                {
                    if (TreasureChest.Count == 0)
                    {
                        
                        Console.WriteLine("Failed treasure hunt.");
                        break;
                    }
                    double totalGain = 0;
                    for (int i = 0; i < TreasureChest.Count; i++)
                    {
                        totalGain += TreasureChest[i].Length;

                    }
                    totalGain /= TreasureChest.Count;
                    Console.WriteLine($"Average treasure gain: {totalGain:f2} pirate credits.");
                    break;
                }
            }

            
        }
    }
}
