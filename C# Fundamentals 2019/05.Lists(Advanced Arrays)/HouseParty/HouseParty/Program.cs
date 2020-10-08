using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            List<string> TotalGuests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> Guests = Console.ReadLine()
                .Split()
                .ToList();

                
                string name = Guests[0];
                

                if(Guests.Contains("not"))
                {
                    if (TotalGuests.Contains(Guests[0]))
                    {
                        TotalGuests.Remove(Guests[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{Guests[0]} is not in the list!");
                    }
                }
                else
                {
                    if(TotalGuests.Contains(Guests[0]))
                    {
                        Console.WriteLine($"{Guests[0]} is already in the list!");
                    }
                    else
                    {
                        TotalGuests.Add(Guests[0]);
                    }
                }  

            }

            Console.WriteLine(string.Join("\n" , TotalGuests));
        }
    }
}
