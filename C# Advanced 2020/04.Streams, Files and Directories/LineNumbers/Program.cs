using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader strreader = new StreamReader("./text.txt");
            int letterCounter = 0;
            int punctCounter = 0;
            int linecount = 0;

            while (!strreader.EndOfStream)
            {
                letterCounter = 0;
                punctCounter = 0;

                string line = strreader.ReadLine();

                for (int i = 0; i < line.Length; i++)
                {
                    if (Char.IsLetter(line[i]))
                    {
                        letterCounter++;
                    }
                    else if (line[i] == '!' || line[i] == ',' || line[i] == ';' || line[i] == '.' || line[i] == '?' || line[i] == '-' || line[i] == '\'' || line[i] == '/' || line[i] == ':')
                    {
                        punctCounter++;
                    }
                }
                linecount++;


                Console.WriteLine($"Line {linecount}: {line} ({letterCounter})({punctCounter})");
            }
        }
    }
}
