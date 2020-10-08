using System;
using System.IO;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamreader = new StreamReader("./text.txt");
            int counter = 0;


            while (!streamreader.EndOfStream)
            {
                string line = streamreader.ReadLine();

                if(line == null)
                {
                    break;
                }

                if(counter % 2 == 0)
                {
                    line = line.Replace('-', '@');
                    line = line.Replace(',', '@');
                    line = line.Replace('.', '@');
                    line = line.Replace('!', '@');
                    line = line.Replace('?', '@');

                   line =  string.Join(' ', line
                       .Split()
                       .Reverse());

                    Console.WriteLine(line);
                }
                counter ++;

            }
        }
    }
}
