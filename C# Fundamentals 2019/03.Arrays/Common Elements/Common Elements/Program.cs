using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                 .Split(" ");

            string[] arr2 = Console.ReadLine()
                .Split(" ");

            foreach (string itemTwo in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    string itemOne = arr1[i];

                    if(itemTwo == itemOne)
                    {
                        Console.Write(itemTwo + " ");
                        
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
