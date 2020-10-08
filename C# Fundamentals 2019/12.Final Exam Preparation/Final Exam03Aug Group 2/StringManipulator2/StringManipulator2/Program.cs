using System;

namespace StringManipulator2
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
                if(command[0] == "Change")
                {
                    char Old = char.Parse(command[1]);
                    char N1 = char.Parse(command[2]);

                    input = input.Replace(Old, N1);
                    Console.WriteLine(input);
                }
                else if(command[0] == "Includes")
                {
                    string test = command[1];
                    if(input.Contains(test))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command[0] == "End")
                {
                    string end = command[1];
                    if(input.EndsWith(end))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command[0] == "Uppercase")
                {
                   input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if(command[0] == "FindIndex")
                {
                    char ch = char.Parse(command[1]);
                    int CH = input.IndexOf(ch);
                    Console.WriteLine(CH);
                }
                else if(command[0] == "Cut")
                {
                    int startIn = int.Parse(command[1]);
                    int count = int.Parse(command[2]);

                    input = input.Substring(startIn, count);
                    Console.WriteLine(input);
                }
                else if(command[0] == "Done")
                {
                    break;
                }




                command = Console.ReadLine()
                    .Split();
            }
        }
    }
}
