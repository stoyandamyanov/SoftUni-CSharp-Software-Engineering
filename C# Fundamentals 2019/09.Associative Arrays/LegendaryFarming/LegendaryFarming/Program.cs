using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            var keyMaterials = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            var junkMaterials = new Dictionary<string, int>();
            bool stop = false;
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split();

                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if(material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;
                        if(keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            if(material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if(material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if(material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }

                            stop = true;
                            break;
                        }
                    }
                    else
                    {
                        if(junkMaterials.ContainsKey(material) == false)
                        {
                            junkMaterials[material] = 0;
                        }
                        
                            junkMaterials[material] += quantity;
                        
                    }

                    
                }
                if (stop == true)
                {
                    
                    break;
                }
            }

            Dictionary<string, int> filteredKeyMaterials = keyMaterials
                        .OrderByDescending(od => od.Value)
                        .ThenBy(od => od.Key)
                        .ToDictionary(a => a.Key, a => a.Value);
            foreach (var od in filteredKeyMaterials)
            {
                string materialn = od.Key;
                int quan = od.Value;
                Console.WriteLine($"{materialn}: {quan}");
            }

            foreach (var item in junkMaterials.OrderBy(item => item.Key))
            {
                string m = item.Key;
                int q = item.Value;

                Console.WriteLine($"{m}: {q}");


            }


        }
    }
}
