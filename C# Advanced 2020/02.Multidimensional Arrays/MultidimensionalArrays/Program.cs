using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[100, 200];

            Console.WriteLine($"{matrix.GetLength(0)}\n{matrix.GetLength(1)}");
            
        }
    }
}
