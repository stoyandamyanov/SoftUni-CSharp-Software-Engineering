using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(':');

            Dictionary<string, int> NameHealth = new Dictionary<string, int>();
            Dictionary<string, int> NameEnergy = new Dictionary<string, int>();

            while (input[0] != "Results")
            {

                if (input[0] == "Add")
                {
                    string name = input[1];
                    int Health = int.Parse(input[2]);
                    int Energy = int.Parse(input[3]);
                    if (!NameHealth.ContainsKey(name))
                    {
                        NameHealth.Add(name, Health);
                        NameEnergy.Add(name, Energy);

                    }
                    else
                    {
                        NameHealth[name] += Health;
                    }
                }
                else if(input[0] == "Attack")
                {
                    string AttackerName = input[1];
                    string DefenderName = input[2];
                    int Damage = int.Parse(input[3]);

                    if(NameHealth.ContainsKey(AttackerName) && NameHealth.ContainsKey(DefenderName))
                    {
                        NameHealth[DefenderName] -= Damage;
                        NameEnergy[AttackerName]--;
                        if(NameHealth[DefenderName] <= 0)
                        {
                            NameHealth.Remove(DefenderName);
                            NameEnergy.Remove(DefenderName);
                            Console.WriteLine($"{DefenderName} was disqualified!");
                        }
                        if(NameEnergy[AttackerName]<= 0)
                        {
                            NameHealth.Remove(AttackerName);
                            NameEnergy.Remove(AttackerName);
                            Console.WriteLine($"{AttackerName} was disqualified!");
                        }
                    }
                }
                else if(input[0] == "Delete")
                {
                    string name = input[1];
                    if (NameHealth.ContainsKey(name))
                    {
                        NameHealth.Remove(name);
                        NameEnergy.Remove(name);
                    }
                    else if(name == "All")
                    {
                        NameHealth.Clear();
                        NameEnergy.Clear();
                    }
                }




                input = Console.ReadLine()
                    .Split(':');
            }

            int count = NameHealth.Count;
            Console.WriteLine($"People count: {count}");

            foreach (var name in NameHealth.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string Name = name.Key;
                int energy = NameEnergy[Name];
                Console.WriteLine($"{name.Key} - {name.Value} - {energy}");

            }

        }
    }
}
