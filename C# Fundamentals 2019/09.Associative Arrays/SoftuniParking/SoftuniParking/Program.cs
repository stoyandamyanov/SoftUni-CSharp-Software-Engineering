using System;
using System.Collections.Generic;

namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n =int.Parse(Console.ReadLine());
            int count = 1;

            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            while (count <= n)
            {
                string[] input = Console.ReadLine()
                .Split();

                

                string command = input[0];
                string user = "";
                string regNumber = "";

                if(command == "register")
                {
                    user = input[1];
                    regNumber = input[2];

                    if(!parkingRegister.ContainsKey(user))
                    {
                        parkingRegister.Add(user, regNumber);
                        Console.WriteLine($"{user} registered {regNumber} successfully");
                    }
                    else if(parkingRegister.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingRegister[user]}");
                    }

                }
                else if(command == "unregister")
                {
                    user = input[1];

                    if(!parkingRegister.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        parkingRegister.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");

                    }
                }

                count++;
            }

            foreach (var user in parkingRegister)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
