using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            int counter = 0;

            for (int i = 0; i < N; i++)
            {
                int[] currentPump = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(currentPump);
            }

            while (true)
            {
                int fuelAmount = 0;
                bool foundBreak = true;

                for (int i = 0; i < N; i++)
                {
                    int[] currPump = pumps.Dequeue();
                    fuelAmount += currPump[0];

                    if (fuelAmount < currPump[1])
                    {
                        foundBreak = false;
                    }

                    fuelAmount -= currPump[1];

                    pumps.Enqueue(currPump);

                }

                if(foundBreak)
                {
                    break;
                }

                counter++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(counter);
        }
    }
}
