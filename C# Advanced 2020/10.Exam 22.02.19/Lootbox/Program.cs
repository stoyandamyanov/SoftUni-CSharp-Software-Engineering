using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLoot = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondLoot = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Queue<int> FirstBox = new Queue<int>(firstLoot);
            Stack<int> SecondBox = new Stack<int>(secondLoot);

            int totalSum = 0;
            int firstboxitem = 0;
            int secondboxitem = 0;

            int currentSum = 0;

            while (true)
            {
                firstboxitem = FirstBox.Peek();
                secondboxitem = SecondBox.Peek();
                currentSum = firstboxitem + secondboxitem;
                

                if(currentSum % 2 == 0)
                {
                    totalSum += currentSum;
                    FirstBox.Dequeue();
                    SecondBox.Pop();
                    if(FirstBox.Count == 0)
                    {
                        Console.WriteLine("First lootbox is empty");
                        break;
                    }
                    else if(SecondBox.Count == 0)
                    {
                        Console.WriteLine("Second lootbox is empty");
                        break;
                    }
                }
                else if(currentSum % 2 != 0)
                {
                    SecondBox.Pop();
                    FirstBox.Enqueue(secondboxitem);
                    if(SecondBox.Count == 0)
                    {
                        Console.WriteLine("Second lootbox is empty");
                        break;
                    }
                }
            }

            if(totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
