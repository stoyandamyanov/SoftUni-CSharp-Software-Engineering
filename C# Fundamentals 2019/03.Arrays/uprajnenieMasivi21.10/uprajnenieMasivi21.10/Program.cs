using System;
using System.Linq;

namespace uprajnenieMasivi21._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string first = arr[0];
                for (int index = 1; index < arr.Length; index++)
                {
                    string current = arr[index];
                    arr[index - 1] = current;
                }

                arr[arr.Length - 1] = first;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
