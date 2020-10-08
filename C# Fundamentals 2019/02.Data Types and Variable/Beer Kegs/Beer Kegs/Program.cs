using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            double biggestOne = double.MinValue;
            string Biggestmodel = "";
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double totalSize = 3.14 * r * r * h;

                if(totalSize >= biggestOne)
                {
                    biggestOne = totalSize;
                    Biggestmodel = model;
                }

            }
            Console.WriteLine(Biggestmodel);
            
        }
    }
}
