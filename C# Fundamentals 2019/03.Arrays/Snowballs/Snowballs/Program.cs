using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            //totalsnowball
            int n = int.Parse(Console.ReadLine());
            BigInteger bestSnowballScore = -999999999999;
            int bestsnow = 0;
            int bestTime = 0;
            int bestQuality = 0;



            for (int i = 1; i <= n; i++)
            {
                int SnowballSnow = int.Parse(Console.ReadLine());
                int SnowBallTime = int.Parse(Console.ReadLine());
                int SnowBallQuality = int.Parse(Console.ReadLine());
                

                BigInteger SnowballValue = BigInteger.Pow((SnowballSnow / SnowBallTime), SnowBallQuality);
                if (SnowballValue > bestSnowballScore)
                {
                    bestSnowballScore = SnowballValue;
                    bestsnow = SnowballSnow;
                    bestTime = SnowBallTime;
                    bestQuality = SnowBallQuality;

                }

                
            }
            Console.WriteLine($"{bestsnow} : {bestTime} = {bestSnowballScore} ({bestQuality})");


        }
    }
}
