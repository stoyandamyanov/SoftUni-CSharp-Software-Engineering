using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting_23Jun2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquids = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            Queue<int> chemicalLiquids = new Queue<int>(liquids);
            Stack<int> physicalItems = new Stack<int>(items);

            SortedDictionary<string, int> AdvancedMaterials = new SortedDictionary<string, int>
            {
                {"Glass", 0 },
                {"Aluminium", 0 },
                {"Lithium", 0},
                {"Carbon fiber", 0 }
            };

            int currentLiquid = 0;
            int currentItem = 0;
            int totalSum = 0;
            while (true)
            {
                currentLiquid = chemicalLiquids.Dequeue();
                currentItem = physicalItems.Peek();

                totalSum = currentLiquid + currentItem;

                if (totalSum == 25)
                {
                    physicalItems.Pop();
                    
                    AdvancedMaterials["Glass"] += 1;
                }
                else if (totalSum == 50)
                {
                    physicalItems.Pop();

                    AdvancedMaterials["Aluminium"] += 1;
                }
                else if(totalSum == 75)
                {
                    physicalItems.Pop();
                    
                    AdvancedMaterials["Lithium"] += 1;   
                }
                else if(totalSum == 100)
                {
                    physicalItems.Pop();

                    AdvancedMaterials["Carbon fiber"] += 1;
                }
                else
                {
                    physicalItems.Pop();
                    physicalItems.Push(currentItem + 3);
                }

                if(chemicalLiquids.Count == 0 || physicalItems.Count == 0)
                {
                    break;
                }
            }

            if(AdvancedMaterials.All(x => x.Value > 0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if(chemicalLiquids.Count != 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",chemicalLiquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if(physicalItems.Count != 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var item in AdvancedMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
