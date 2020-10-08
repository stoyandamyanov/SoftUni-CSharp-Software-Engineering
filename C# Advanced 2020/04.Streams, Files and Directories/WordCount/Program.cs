using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamreaderText = new StreamReader("./text.txt");
            StreamReader streamreaderWords = new StreamReader("./words.txt");

            Dictionary<string, int> WordsandCounts = new Dictionary<string, int>();
            List<string> AllWords = new List<string>();

            while (!streamreaderWords.EndOfStream)
            {
                string word = streamreaderWords.ReadLine();

                if (!WordsandCounts.ContainsKey(word))
                {
                    WordsandCounts.Add(word, 0);
                    AllWords.Add(word);
                }

            }
            while (!streamreaderText.EndOfStream)
            {
                string[] line = streamreaderText.ReadLine().ToLower().Split(new Char[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < AllWords.Count; i++)
                {
                    string WORD = AllWords[i];

                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j].Equals(WORD))
                        {
                            WordsandCounts[WORD]++;
                        }
                    }
                }
            }

            StreamWriter newFile = new StreamWriter("../../../actualResults.txt");

            foreach (var item in WordsandCounts)
            {
                newFile.WriteLine($"{item.Key} - {item.Value}");
            }
             newFile.Close();

            StreamWriter DescendingOrder = new StreamWriter("../../../sortedResult.txt");
            {
                foreach (var item in WordsandCounts.OrderByDescending(x => x.Value))
                {
                    DescendingOrder.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            DescendingOrder.Close();
        }
    }
}
