using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(": ");

            Dictionary<string, int> FLikes = new Dictionary<string, int>();
            Dictionary<string, int> FComments = new Dictionary<string, int>();

            while (true)
            {
                if(input[0] == "Log out")
                {
                    break;
                }

                if(input[0] == "New follower")
                {
                    string follower = input[1];
                    if(!FLikes.ContainsKey(follower))
                    {
                        FLikes.Add(follower, 0);
                        FComments.Add(follower, 0);
                    }
                }
                else if(input[0] == "Like")
                {
                    string name = input[1];
                    int count = int.Parse(input[2]);

                    if(!FLikes.ContainsKey(name))
                    {
                        FLikes.Add(name,count);
                        FComments.Add(name, 0);
                    }
                    else
                    {
                        FLikes[name] += count;
                    }
                }
                else if(input[0] == "Comment")
                {
                    string name = input[1];
                    
                    if(!FComments.ContainsKey(name))
                    {
                        FComments.Add(name, 1);
                        FLikes.Add(name, 0);
                    }
                    else
                    {
                        FComments[name] += 1;
                    }
                }
                else if(input[0] == "Blocked")
                {
                    string name = input[1];

                    if(!FLikes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else
                    {
                        FLikes.Remove(name);
                        FComments.Remove(name);
                    }
                }

                input = Console.ReadLine()
                    .Split(": ");
            }

            int counterPeople = FLikes.Count;
            Console.WriteLine($"{counterPeople} followers");

            foreach (var follower in FLikes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                int total = FLikes[follower.Key] + FComments[follower.Key];
                Console.WriteLine($"{follower.Key}: {total}");
            }
        }
    }
}
