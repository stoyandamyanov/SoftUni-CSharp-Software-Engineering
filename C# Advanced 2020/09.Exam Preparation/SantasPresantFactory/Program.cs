using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasPresantFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] materials = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] magicValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Dictionary<string, int> ToysandAmount = new Dictionary<string, int>();

            Stack<int> BoxeswithMaterials = new Stack<int>();
            Queue<int> MagicValues = new Queue<int>();


            for (int i = 0; i < materials.Length; i++)
            {
                BoxeswithMaterials.Push(materials[i]);
            }
            for (int i = 0; i < magicValues.Length; i++)
            {
                MagicValues.Enqueue(magicValues[i]);
            }
            int product = 0;
            int material = 0;
            int magic = 0;
            int DollsCount = 0;
            int TrainsCount = 0;
            int TeddyBears = 0;
            int Bicycles = 0;
            int newMateriavalue = 0;
            
            while (true)
            {
                material = BoxeswithMaterials.Peek();
                magic = MagicValues.Peek();
               
                if(material == 0)
                {
                    BoxeswithMaterials.Pop();
                    if (BoxeswithMaterials.Count > 0)
                    {
                        material = BoxeswithMaterials.Peek();
                    }
                    else
                    {
                        if(MagicValues.Count == 1 && MagicValues.Peek() == 0)
                        {
                            MagicValues.Dequeue();
                        }
                        break;
                    }
                }
                if(magic == 0)
                {
                    MagicValues.Dequeue();
                    if (MagicValues.Count > 0)
                    {
                        magic = MagicValues.Peek();
                    }
                    else
                    {
                        if (BoxeswithMaterials.Count == 1 && BoxeswithMaterials.Peek() == 0)
                        {
                            BoxeswithMaterials.Pop();
                        }
                        break;
                    }

                }
                product = material * magic;
                if(product < 0)
                {
                    newMateriavalue = material + magic;
                    BoxeswithMaterials.Pop();
                    MagicValues.Dequeue();
                    BoxeswithMaterials.Push(newMateriavalue);
                }
                if(product > 0 && product != 150 && product != 250 && product != 300 && product != 400)
                {
                    MagicValues.Dequeue();
                    material = BoxeswithMaterials.Peek() + 15;
                    BoxeswithMaterials.Pop();
                    BoxeswithMaterials.Push(material);
                }
                if (product == 150 )
                {
                    DollsCount++;
                    BoxeswithMaterials.Pop();
                    MagicValues.Dequeue();
                    
                    if(!ToysandAmount.ContainsKey("Doll"))
                    {
                        ToysandAmount.Add("Doll", 1);
                    }
                    else
                    {
                        ToysandAmount["Doll"] += 1;
                    }
                }
                else if(product == 250)
                {
                    TrainsCount++;
                    BoxeswithMaterials.Pop();
                    MagicValues.Dequeue();

                    if(!ToysandAmount.ContainsKey("Wooden train"))
                    {
                        ToysandAmount.Add("Wooden train", 1);
                    }
                    else
                    {
                        ToysandAmount["Wooden train"] += 1;
                    }
                }
                else if(product == 300)
                {
                    TeddyBears++;
                    BoxeswithMaterials.Pop();
                    MagicValues.Dequeue();

                    if(!ToysandAmount.ContainsKey("Teddy bear"))
                    {
                        ToysandAmount.Add("Teddy bear", 1);
                    }
                    else
                    {
                        ToysandAmount["Teddy bear"] += 1;
                    }
                }
                else if(product == 400)
                {
                    Bicycles++;
                    BoxeswithMaterials.Pop();
                    MagicValues.Dequeue();

                    if(!ToysandAmount.ContainsKey("Bicycle"))
                    {
                        ToysandAmount.Add("Bicycle", 1);
                    }
                    else
                    {
                        ToysandAmount["Bicycle"] += 1;
                    }

                }
                if(BoxeswithMaterials.Count == 0 || MagicValues.Count == 0)
                {
                    break;
                }
            }

            if(DollsCount >= 1 && TrainsCount >= 1 || TeddyBears >= 1 && Bicycles >= 1)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if(BoxeswithMaterials.Count > 0)
            {
                Console.WriteLine($"Materials left: { string.Join(", ", BoxeswithMaterials)}");
            }
            if(MagicValues.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", MagicValues)}");
            }

            foreach (var Toy in ToysandAmount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{Toy.Key}: {Toy.Value}");
            }
        }
    }
}
