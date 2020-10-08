using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            var ListofNames = new HashSet<string>();

            while (counter != n)
            {
                counter++;

                string name = Console.ReadLine();

                ListofNames.Add(name);
            }

            foreach (var name in ListofNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
