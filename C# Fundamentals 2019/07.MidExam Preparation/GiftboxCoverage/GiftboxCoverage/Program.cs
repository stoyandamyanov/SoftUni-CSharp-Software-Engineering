using System;
using System.Linq;

namespace GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeofSide = double.Parse(Console.ReadLine());
            int sheetsTotal = int.Parse(Console.ReadLine());
            double areaofSheet = double.Parse(Console.ReadLine());

            double totalCoveredArea = 0.0;
            int totalSheetslower = 0;
            int normalSheets = 0;
            double neededCover = sizeofSide * sizeofSide * 6;

            for (int i = 1; i <= sheetsTotal; i++)
            {
                if(i % 3 == 0)
                {
                    totalSheetslower++;
                    

                    
                }
                else
                {
                   
                    normalSheets++;
                   
                }
                
            }
            totalCoveredArea += areaofSheet * 0.25 * totalSheetslower;
            totalCoveredArea += areaofSheet * normalSheets;
            totalCoveredArea *= 100 / neededCover;
            Console.WriteLine($"You can cover {totalCoveredArea:f2}% of the box.");
        }
    }
}
