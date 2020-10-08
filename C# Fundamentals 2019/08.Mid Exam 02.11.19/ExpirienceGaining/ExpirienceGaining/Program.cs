using System;

namespace ExpirienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededXP = double.Parse(Console.ReadLine());
            int countBattle = int.Parse(Console.ReadLine());
            double TotalXP = 0;
            int countBattleNeeded = 0;
            for (int i = 1; i <= countBattle; i++)
            {
                double XpperBattle = double.Parse(Console.ReadLine());


                if(i % 3 == 0)
                {
                    TotalXP += XpperBattle + XpperBattle * 0.15;

                }
                if(i % 5 == 0)
                {
                    TotalXP += XpperBattle - XpperBattle * 0.10;
                }
                else if(i % 3 !=0 && i % 5 !=0)
                {
                    TotalXP += XpperBattle;
                }


                countBattleNeeded++;
                if(TotalXP >=neededXP)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {countBattleNeeded} battles.");
                    break;
                }
                
            }
            if(neededXP > TotalXP)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededXP - TotalXP:f2} more needed.");
            }

        }
    }
}
