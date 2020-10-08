using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();
            
            while (command != "Output")
            {
                string[] input = command.Split();
                var departament = input[0];
                var FirstName = input[1];
                var SurName = input[2];
                var pacient = input[3];
                var fullName = FirstName + SurName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();

                    for (int rooms = 1; rooms <= 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool IsAvailableSpace = departments[departament].SelectMany(x => x).Count() < 60;

                if (IsAvailableSpace)
                {
                    int room = 0;

                    doctors[fullName].Add(pacient);

                    for (int r = 0; r < departments[departament].Count; r++)
                    {
                        if (departments[departament][r].Count < 3)
                        {
                            room = r;
                            break;
                        }
                    }
                    departments[departament][room].Add(pacient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int staq))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
