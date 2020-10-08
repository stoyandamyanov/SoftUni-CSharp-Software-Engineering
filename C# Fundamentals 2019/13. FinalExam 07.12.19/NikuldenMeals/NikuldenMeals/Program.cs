using System;
using System.Collections.Generic;
using System.Linq;

namespace NikuldenMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split('-');
            int unlikedMealsCount = 0;
            Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> unLikedMeals = new Dictionary<string, List<string>>();

            while (true)
            {
                if(command[0] == "Like")
                {
                    string name = command[1];
                    string meal = command[2];

                    if (!likedMeals.ContainsKey(name))
                    {
                        likedMeals.Add(name, new List<string>());
                        likedMeals[name].Add(meal);
                    }
                    if(!likedMeals[name].Contains(meal))
                    {
                        likedMeals[name].Add(meal);
                    }
                }
                else if(command[0] == "Unlike")
                {
                    string name = command[1];
                    string meal = command[2];

                    if(!likedMeals.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }
                    else
                    {
                        if (likedMeals[name].Contains(meal))
                        {
                            likedMeals[name].Remove(meal);
                            unlikedMealsCount++;
                            Console.WriteLine($"{name} doesn't like the {meal}.");
                        }
                        else if(!likedMeals[name].Contains(meal))
                        {
                            Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                        }
                    }
                }
                else if(command[0] == "Stop")
                {
                    foreach (var client in likedMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                    {
                        Console.Write($"{client.Key}: ");
                        Console.Write(string.Join(", ", client.Value));
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Unliked meals: {unlikedMealsCount}");
                    break;
                }
                command = Console.ReadLine()
                    .Split('-');
            }
        }
    }
}
