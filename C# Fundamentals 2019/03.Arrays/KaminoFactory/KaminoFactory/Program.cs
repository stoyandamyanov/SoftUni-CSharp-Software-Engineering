using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command = null;
            
            int bestCount = 0;
            int bestSum = 0;
            int bestbeginIndex = 0;
            string bestSequence = "";
            int counter = 0;
            int bestcounter = 0;

            while((command=Console.ReadLine()) != "Clone them!")
            {
                string sequence = command.Replace("!", "");
                string[] DNAparts = sequence.Split("0",StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string bestSubsequence = "";
                counter++;
                
                foreach (string part in DNAparts)
                {
                    if(part.Length > count)
                    {
                        count = part.Length;
                        bestSubsequence = part;
                    }
                    sum += part.Length;
                }

                int beginIndex = sequence.IndexOf(bestSubsequence);

                if(count > bestCount || (count == bestCount && beginIndex < bestbeginIndex)|| (count == bestCount && beginIndex == bestbeginIndex && sum > bestSum) ||(counter == 1))
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestbeginIndex = beginIndex;
                    bestSum = sum;
                    bestcounter = counter;
                }
            }
            char[] arrRes = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestcounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ",arrRes));
        }
    }
}
