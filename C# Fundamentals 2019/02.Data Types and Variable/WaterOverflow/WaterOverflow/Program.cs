using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalin = 0;
            for (int i = 1; i <= n; i++)
            {
                int income = int.Parse(Console.ReadLine());
                totalin += income;
                if(totalin > 255)
                {
                    Console.WriteLine("Incufficient capacity!");
                    totalin -= income;
                }
                
            }
            Console.WriteLine(totalin);
        }
    }
}
