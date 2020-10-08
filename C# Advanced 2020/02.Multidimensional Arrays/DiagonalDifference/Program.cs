using System;
using System.Linq;



namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());


            int rows = dimensions;
            int cols = dimensions;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int FirstDiagonalSum = 0;
            int SecondDiagonalSum = 0;
           
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                FirstDiagonalSum += matrix[row, row];
            }

            for (int  row = 0;  row < matrix.GetLength(0);  row++)
            {
                int COL = cols - 1;
                SecondDiagonalSum += matrix[row,COL - row];
            }

            Console.WriteLine(Math.Abs(FirstDiagonalSum - SecondDiagonalSum));
        }
    }
}
