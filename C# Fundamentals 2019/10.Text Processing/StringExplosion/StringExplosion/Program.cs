using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int str = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if(ch == '>')
                {
                    str += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if(str > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    str--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
