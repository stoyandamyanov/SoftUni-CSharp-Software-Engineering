using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            string name = Console.ReadLine();

            var names = new HashSet<string>();

            while (true)
            {
                counter++;
                names.Add(name);
                if(counter == n)
                {
                    break;
                }

                 name = Console.ReadLine();
            }

            foreach (var namE in names)
            {
                Console.WriteLine(namE);
            }
        }
    }
}
