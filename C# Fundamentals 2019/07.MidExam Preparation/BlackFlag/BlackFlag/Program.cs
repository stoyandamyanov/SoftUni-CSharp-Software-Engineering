using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysofPlunder = int.Parse(Console.ReadLine());
            int dailyIncoming = int.Parse(Console.ReadLine());
            double FinalTarget = double.Parse(Console.ReadLine());

            double totalPlunder = 0;
          


            for (int i = 1; i <= daysofPlunder; i++)
            {
                totalPlunder += dailyIncoming;
                if (i % 3 == 0)
                {
                    totalPlunder += dailyIncoming * 0.5;
                }
                if (i % 5 == 0)
                {
                    
                    totalPlunder = totalPlunder - (totalPlunder * 0.3);
                }
                
            }    
            
            if(totalPlunder >= FinalTarget)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                totalPlunder = totalPlunder * 100 / FinalTarget;
                Console.WriteLine($"Collected only {totalPlunder:f2}% of the plunder.");
            }
        }
    }
}
