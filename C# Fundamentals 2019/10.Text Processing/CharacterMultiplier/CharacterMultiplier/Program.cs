using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
               .Split();

            int sum = 0;
            
            string strOne = input[0];
            string strTwo = input[1];
            int minLenght = Math.Min(strOne.Length, strTwo.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += strOne[i] * strTwo[i];

            }
            string longestString = strOne;

            if(longestString.Length < strTwo.Length)
            {
                longestString = strTwo;
            }

            for (int j = minLenght; j < longestString.Length; j++)
            {
                sum += longestString[j];
            }
            Console.WriteLine(sum);
        }
    }
}
