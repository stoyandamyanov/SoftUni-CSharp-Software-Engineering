using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split('=')
                .ToArray();

            Dictionary<string,int> sended = new Dictionary<string,int>();
            Dictionary<string, int> received = new Dictionary<string, int>();
            Dictionary<string, int> totalMessages = new Dictionary<string, int>();
            while (true)
            {
                if(input[0] == "Add")
                {
                    string name = input[1];
                    int sendM = int.Parse(input[2]);
                    int receivedM = int.Parse(input[3]);

                    if(!sended.ContainsKey(name))
                    {
                        sended.Add(name, sendM);
                        received.Add(name, receivedM);
                        int totalM = sended[name] + received[name];
                        if(!totalMessages.ContainsKey(name))
                        {
                            totalMessages.Add(name, totalM);
                        }
                    }
                }
                else if(input[0] == "Message")
                {
                    string sender = input[1];
                    string receiver = input[2];

                    if(sended.ContainsKey(sender) && sended.ContainsKey(receiver))
                    {
                        sended[sender] += 1;
                        received[receiver] += 1;
                        totalMessages[sender] += 1;
                        totalMessages[receiver] += 1;

                        if(totalMessages[sender] >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            sended.Remove(sender);
                            received.Remove(sender);
                            totalMessages.Remove(sender);
                        }
                        if(totalMessages[receiver] >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            sended.Remove(receiver);
                            received.Remove(receiver);
                            totalMessages.Remove(receiver);
                        }
                    }
                }
                else if(input[0] == "Empty")
                {
                    string name = input[1];
                    if(name == "All")
                    {
                        sended.Clear();
                        received.Clear();
                        totalMessages.Clear();
                    }
                    else if(name != "All")
                    {
                        sended.Remove(name);
                        received.Remove(name);
                        totalMessages.Remove(name);
                    }
                }
                else if(input[0] == "Statistics")
                {
                    int counter = sended.Count;
                    Console.WriteLine($"Users count: {counter}");
                    if (counter == 0)
                    {
                        break;
                    }
                    
                    foreach (var user in received.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        
                        int total = totalMessages[user.Key];
                        Console.WriteLine($"{user.Key} - {total}");
                    }
                    break;
                }

                input = Console.ReadLine()
                .Split('=')
                .ToArray();
            }
        }
    }
}
