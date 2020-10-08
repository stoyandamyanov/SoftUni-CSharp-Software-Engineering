using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            string[] command = Console.ReadLine()
                .Split();

            while (true)
            {
                string comm = command[0];

                

                if(comm == "swap")
                {
                    if(command.Length < 5 || command.Length > 5)
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine()
                            .Split();
                        continue;
                    }
                    int oldRow = int.Parse(command[1]);
                    int oldCol = int.Parse(command[2]);
                    int newRow = int.Parse(command[3]);
                    int newCol = int.Parse(command[4]);


                    if (oldRow >= 0 && oldRow <= matrix.GetLength(0) - 1 && oldCol >= 0 && oldCol <= matrix.GetLength(1) - 1 && newRow >= 0 && newRow <= matrix.GetLength(0) - 1 && newCol >= 0 && newCol <= matrix.GetLength(1) - 1)
                    {
                        string old = matrix[oldRow, oldCol];
                        string newOne = matrix[newRow, newCol];

                        matrix[oldRow, oldCol] = newOne;
                        matrix[newRow, newCol] = old;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if(comm == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                
                
                command = Console.ReadLine()
                    .Split();
            }
        }
    }
}
