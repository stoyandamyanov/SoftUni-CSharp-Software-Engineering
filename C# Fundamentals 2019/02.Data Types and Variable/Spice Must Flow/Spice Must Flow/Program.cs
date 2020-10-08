using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingyeild = int.Parse(Console.ReadLine());
            int amount = 0;
            int countDay = 0;

            while (startingyeild >= 100)
            {
                amount += startingyeild;
                startingyeild -= 10;
                countDay++;
                if (amount - 26 < 0)
                {
                    amount = 0;
                }
                else
                {
                    amount -= 26;
                }
            }
            if (amount - 26 < 0)
            {
                amount = 0;
            }
            else
            {
                amount -= 26;
            }
            Console.WriteLine($"{countDay}\n{amount}");

        }
    }
}
