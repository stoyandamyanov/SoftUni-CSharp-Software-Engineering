using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];


            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentSum = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentSum[col];
                }
            }

            int MaxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;



            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > MaxSum)
                    {
                        MaxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {MaxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}\n" +
                $"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}\n" +
                $"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
        }
    }
}
