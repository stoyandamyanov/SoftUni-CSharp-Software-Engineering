using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counterTarget = 0;
            double Noriginal = N;

            while (N >= M)
            {
                
                
                if(((double)N/Noriginal)*100 == 50)
                {
                    if (exhaustionFactor != 0)
                    {
                        N /= exhaustionFactor;
                    }
                    if(N >= M)
                    {
                        N -= M;
                        counterTarget++;
                    }
                    
                }
                else
                {
                    N -= M;
                    counterTarget++;
                }

            }
            Console.WriteLine($"{N}\n{counterTarget}");
        }
    }
}
