using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> PirateshipStatus = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            List<int> WarshipStatus = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            int MaxHealthSection = int.Parse(Console.ReadLine());
            int countWin = 0;
            int countLose = 0;

            while (true)
            {
                List<string> Command = Console.ReadLine()
                    .Split()
                    .ToList();

                if (Command[0] == "Fire")
                {
                    int index = int.Parse(Command[1]);
                    int damage = int.Parse(Command[2]);

                    if (index < 0 || index > WarshipStatus.Count)
                    {
                        continue;
                    }
                    else if (index >= 0 && index <= WarshipStatus.Count - 1)
                    {
                        WarshipStatus[index] = WarshipStatus[index] - damage;

                        if (WarshipStatus[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            countWin++;
                        }
                    }
                }
                else if (Command[0] == "Defend")
                {
                    int startIndex = int.Parse(Command[1]);
                    int endIndex = int.Parse(Command[2]);
                    int damage = int.Parse(Command[3]);

                    if (startIndex < 0 || startIndex > PirateshipStatus.Count && endIndex < 0 || endIndex > PirateshipStatus.Count)
                    {
                        continue;
                    }
                    else if ((startIndex >= 0 && startIndex <= WarshipStatus.Count - 1) && endIndex >= 0 || endIndex <= PirateshipStatus.Count - 1)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            PirateshipStatus[i] = PirateshipStatus[i] - damage;
                            if (PirateshipStatus[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                countLose++;
                                break;

                            }
                        }



                    }

                }
                else if (Command[0] == "Repair")
                {
                    int index = int.Parse(Command[1]);
                    int healthR = int.Parse(Command[2]);

                    if (index < 0 || index > PirateshipStatus.Count)
                    {
                        continue;
                    }
                    else if (index >= 0 && index <= PirateshipStatus.Count - 1)
                    {
                        PirateshipStatus[index] += healthR;

                        if (PirateshipStatus[index] > MaxHealthSection)
                        {
                            PirateshipStatus[index] = MaxHealthSection;
                        }
                    }
                }
                else if (Command[0] == "Status")
                {
                    double minHealth = 0;
                    minHealth = MaxHealthSection * 0.2;
                    int count = 0;

                    for (int i = 0; i < PirateshipStatus.Count; i++)
                    {
                        if (PirateshipStatus[i] < minHealth)
                        {
                            count++;
                        }

                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
                else if (countWin == 0 && countLose == 0)
                {
                    int pirateShipSum = 0;
                    int warShipSum = 0;
                    foreach (int item in PirateshipStatus)
                    {
                        pirateShipSum += item;

                    }
                    foreach (int item in WarshipStatus)
                    {
                        warShipSum += item;
                    }

                    Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                    Console.WriteLine($"Warship status: {warShipSum}");
                    break;
                }
                else if (Command[0] == "Retire")
                {
                    break;
                }


            }


        }
    }
}
