using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            
            int[][] PascalTriangle = new int[rows][];
            
            if (rows >= 1)
            {
                PascalTriangle[0] = new[] { 1 };
            }

            if(rows >= 2)
            {
                PascalTriangle[1] = new[] { 1, 1 };
            }
           

            for (int row = 0; row < rows; row++)
            {
                PascalTriangle[row] = new int[row +1];
                PascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    PascalTriangle[row][col] =
                        PascalTriangle[row - 1][col] +
                        PascalTriangle[row - 1][col - 1];
                }

                PascalTriangle[row][row] = 1;

            }


            foreach (var currentRow in PascalTriangle)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }
    }
}
