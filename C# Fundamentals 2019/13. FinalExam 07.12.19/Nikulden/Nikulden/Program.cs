using System;

namespace Nikulden
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine()
                .Split();

            while (true)
            {
                if (command[0] == "Finish")
                {
                    break;
                }

                if (command[0] == "Replace")
                {
                    char current = char.Parse(command[1]);
                    char newOne = char.Parse(command[2]);
                    input = input.Replace(current, newOne);
                    Console.WriteLine(input);
                }
                else if(command[0] == "Cut")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);
                    if((start >= 0 && start<= input.Length -1)&& (end <= input.Length - 1 && end >=0))
                    {
                        input = input.Remove(start, end);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if(command[0] == "Make")
                {
                    string comm = command[1];

                    if(comm == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else if(comm == "Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if(command[0] == "Check")
                {
                    string current = command[1];

                    if(input.Contains(current))
                    {
                        Console.WriteLine($"Message contains {current}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {current}");
                    }
                }
                else if(command[0] == "Sum")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);
                    int total = 0;
                    if((start >= 0 && start <= input.Length - 1)&& (end <= input.Length - 1 && end >=0))
                    {
                        string sub = input.Substring(start, end);
                        for (int i = 0; i <= sub.Length - 1; i++)
                        {
                            char ch = sub[i];
                            total += ch;
                        }
                        Console.WriteLine(total);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                

                command = Console.ReadLine()
                    .Split();
            }
        }
    }
}
