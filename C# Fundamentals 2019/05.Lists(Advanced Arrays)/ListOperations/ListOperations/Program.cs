using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = null;
            int item = 0;
            int InsertNum = 0;
            int InsertIndex = 0;
            string commandShift = null;

            while (command != "End")
            {
                List<string> command1 = Console.ReadLine()
                .Split()
                .ToList();

                
                
                command = command1[0];
                if(command == "End")
                {
                    break;
                }
                commandShift = command1[1];
                if(command == "Add")
                {
                    item = int.Parse(command1[1]);
                    numbers.Insert(numbers.Count, item);
                }
                else if(command == "Insert")
                {
                    InsertIndex = int.Parse(command1[2]);
                    if(InsertIndex > numbers.Count || InsertIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    InsertNum = int.Parse(command1[1]);
                    numbers.Insert(InsertIndex,InsertNum);
                }
                else if(command == "Remove")
                {
                    item = int.Parse(command1[1]);
                    if(item > numbers.Count || item < 0)
                    {
                        Console.WriteLine("Invalid index");

                        continue;
                    }
                   
                    numbers.RemoveAt(item);
                }
                else if(commandShift == "left")
                {
                    item = int.Parse(command1[2]);
                    for (int i = 0; i < item; i++)
                    {
                        int first = numbers[0];
                        
                        numbers.RemoveAt(0);
                        numbers.Insert(numbers.Count, first);
                    }
                }
                else if(commandShift == "right")
                {
                    item = int.Parse(command1[2]);

                    for (int i = 0; i < item; i++)
                    {
                        int last = numbers[numbers.Count - 1];

                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, last);
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
