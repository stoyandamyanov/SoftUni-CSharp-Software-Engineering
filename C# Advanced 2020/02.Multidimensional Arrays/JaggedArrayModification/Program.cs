using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                array[row] = currentRow;

            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if(command == "end")
                {
                    foreach (var rowcurr in array)
                    {
                        Console.WriteLine(string.Join(" ",rowcurr));
                    }
                    break;
                }

                var commandParts = command.Split();
               
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if(row < 0 || row >= rows || col < 0 || col >= array[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if(commandParts[0] == "add")
                {
                    array[row][col] += value;
                }
                else if(commandParts[0] == "subtract")
                {
                    array[row][col] -= value;
                }
            }
        }
    }
}
