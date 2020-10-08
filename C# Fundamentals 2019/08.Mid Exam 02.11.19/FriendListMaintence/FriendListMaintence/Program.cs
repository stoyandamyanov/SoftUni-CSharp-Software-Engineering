using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendListMaintence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> FriendsList = Console.ReadLine()
                .Split(", ")
                .ToList();

            int counterBlacklisted = 0;
            int counterLost = 0;
            while(true)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();
                
                if (command[0] == "Blacklist")
                {
                    if(FriendsList.Contains(command[1]))
                    {
                        int index = FriendsList.IndexOf(command[1]);
                        FriendsList.Remove(command[1]);
                        FriendsList.Insert(index,"Blacklisted");
                        Console.WriteLine($"{command[1]} was blacklisted.");
                        counterBlacklisted++;
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }
                else if(command[0] == "Error")
                {
                    int index = int.Parse(command[1]);

                    if(FriendsList[index] != "Blacklisted" && FriendsList[index] != "Lost")
                    {
                        int n = FriendsList.IndexOf(FriendsList[index]);
                        string name = FriendsList[index];
                        FriendsList.Remove(FriendsList[index]);
                        FriendsList.Insert(n, "Lost");

                        Console.WriteLine($"{name} was lost due to an error.");
                        counterLost++;
                    }

                }
                else if(command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];

                    if(index >=0 && index < FriendsList.Count)
                    {
                        string oldName = FriendsList[index];
                        FriendsList.Remove(oldName);
                        FriendsList.Insert(index, newName);
                        Console.WriteLine($"{oldName} changed his username to {newName}. ");

                    }
                }
                else if(command[0] == "Report")
                {
                    Console.WriteLine($"Blacklisted names: {counterBlacklisted} ");
                    Console.WriteLine($"Lost names: {counterLost} ");
                    Console.WriteLine(string.Join(" ", FriendsList));
                    break;
                }
                 
            }
        }
    }
}
