using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\");

            string[] nameandExt = input[input.Length - 1].Split('.');


            Console.WriteLine($"File name: {nameandExt[0]}\nFile extension: {nameandExt[1]}");
        }
    }
}
