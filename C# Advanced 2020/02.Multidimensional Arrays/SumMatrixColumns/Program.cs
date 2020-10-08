using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = ParseArrayFromConsole(' ', ',');

            int rows = dimension[0];
            int cols = dimension[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRows = ParseArrayFromConsole(',',' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRows[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumofCurrentColumn = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumofCurrentColumn += matrix[row,col];
                }

                Console.WriteLine(sumofCurrentColumn);
            }

        }

        static int[] ParseArrayFromConsole(params char[] splitSymbols)
        {
            return
                Console.ReadLine()
                .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
