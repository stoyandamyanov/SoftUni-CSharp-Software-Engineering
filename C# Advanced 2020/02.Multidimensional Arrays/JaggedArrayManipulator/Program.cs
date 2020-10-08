using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jagged = new double[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                double[] col = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

                jagged[row] = col;
            }

            for (int currentRow = 0; currentRow <= jagged.Length - 2; currentRow++)
            {
                if(jagged[currentRow].Length == jagged[currentRow + 1].Length)
                {
                    for (int col = 0; col < jagged[currentRow].Length; col++)
                    {
                        jagged[currentRow][col] *= 2;
                        jagged[currentRow + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[currentRow].Length; col++)
                    {
                        jagged[currentRow][col] /= 2;
                    }

                    for (int col = 0; col < jagged[currentRow + 1].Length; col++)
                    {
                        jagged[currentRow + 1][col] /= 2;
                    }
                }
            }

            string[] command = Console.ReadLine()
                .Split();

            while (true)
            {
                string comm = command[0];

                if(comm == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if(jagged.Length - 1>= row && row >= 0 && jagged[row].Length - 1 >= col && col >= 0)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        command = Console.ReadLine()
                            .Split();
                        continue;
                    }
                }
                else if(comm == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if(jagged.Length - 1>= row && row >= 0 && jagged[row].Length - 1>= col && col >= 0)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        command = Console.ReadLine()
                            .Split();
                        continue;
                    }
                }
                else if(comm == "End")
                {
                    foreach (var row in jagged)
                    {
                        Console.WriteLine(string.Join(" ", row));
                    }
                    break;
                }

                command = Console.ReadLine()
                    .Split();
            }
        }
    }
}
