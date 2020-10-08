using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split();

                if(line[0] == "end")
                {
                    break;
                }

                int element = int.Parse(line[1]);
                string command = line[0];

                if(command == "Delete")
                {
                    while (listOfIntegers.Contains(element))
                    {
                        listOfIntegers.Remove(element);
                    }
                }
                
                else if(command == "Insert")
                {
                   int posit = int.Parse(line[2]);

                    listOfIntegers.Insert(posit, element);
                }
                

            }
            Console.WriteLine(string.Join(" ", listOfIntegers));



        }
    }
}
