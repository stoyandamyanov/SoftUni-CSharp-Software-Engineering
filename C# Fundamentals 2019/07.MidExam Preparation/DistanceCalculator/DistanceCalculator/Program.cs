using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double LenghtperStep = double.Parse(Console.ReadLine());
            int distancetoTravel = int.Parse(Console.ReadLine());
            int count = 0;
            double totalPercentage = 0;
            double shorterLenght = LenghtperStep - LenghtperStep * 0.3;
            for (int i = 1; i <= steps; i++)
            {
                if(i % 5 == 0)
                {
                    count++;
                }


            }
            double Shortersteps = (shorterLenght * count) / 100;
            int normalstepscount = steps - count;
            double NormalSteps = (normalstepscount * LenghtperStep) / 100;
            double total = (Shortersteps + NormalSteps) ;

            double finalPercantage = (total / distancetoTravel) * 100;

            Console.WriteLine($"You travelled {finalPercantage:f2}% of the distance!");


        }
    }
}
