using System;
using System.Linq;

namespace finalExam03AugustGroup1stringManip
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentense = Console.ReadLine();
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            while (input[0] != "End")
            {
                if (input[0] == "Translate")
                {
                    char oldCH = char.Parse(input[1]);
                    char newCH = char.Parse(input[2]);

                    sentense = sentense.Replace(oldCH, newCH);
                    Console.WriteLine(sentense);
                }
                else if (input[0] == "Includes")
                {
                    string test = input[1];
                    if (sentense.Contains(test))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (input[0] == "Start")
                {
                    string begin = input[1];
                    if (sentense.StartsWith(begin))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (input[0] == "Lowercase")
                {
                    sentense = sentense.ToLower();
                    Console.WriteLine(sentense);
                }
                else if (input[0] == "FindIndex")
                {
                    char ch = char.Parse(input[1]);
                    int index = sentense.LastIndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (input[0] == "Remove")
                {
                    int startIn = int.Parse(input[1]);
                    int count = int.Parse(input[2]);
                    sentense = sentense.Remove(startIn, count);
                    Console.WriteLine(sentense);
                }



                input = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }
    }
}
