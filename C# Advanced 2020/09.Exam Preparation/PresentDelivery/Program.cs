using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentsCount = int.Parse(Console.ReadLine());

            int dimensions = int.Parse(Console.ReadLine());

            int rows = dimensions;
            int cols = dimensions;

            int SantaRow = 0;
            int SantaCol = 0;

            int niceKidsCount = 0;
            int TotalGoodKids = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(currentRow[col]);

                    if (matrix[row, col] == 'S')
                    {
                        SantaRow = row;
                        SantaCol = col;
                    }
                    if (matrix[row, col] == 'V')
                    {
                        niceKidsCount++;

                    }
                }
                TotalGoodKids = niceKidsCount;
            }
            string command = Console.ReadLine();

            while (presentsCount != 0)
            {
                if (command == "Christmas morning")
                {
                    break;
                }
                if (command == "up")
                {
                    if (SantaRow == 0)
                    {
                        Console.WriteLine("Santa ran out of presents.");
                        matrix[SantaRow, SantaCol] = '-';
                        break;
                    }
                    if (matrix[SantaRow - 1, SantaCol] == 'X')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow - 1, SantaCol] = 'S';
                        SantaRow -= 1;
                    }
                    else if (matrix[SantaRow - 1, SantaCol] == 'V')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow - 1, SantaCol] = 'S';
                        SantaRow -= 1;
                        niceKidsCount--;
                        presentsCount--;
                    }
                    else if (matrix[SantaRow - 1, SantaCol] == 'C')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow - 1, SantaCol] = 'S';
                        SantaRow -= 1;

                            if (matrix[SantaRow - 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow - 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow - 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                            if (matrix[SantaRow, SantaCol - 1] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow, SantaCol - 1] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow, SantaCol - 1] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }

                            if (matrix[SantaRow + 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow + 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow + 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                        
                            if (matrix[SantaRow, SantaCol + 1] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow, SantaCol + 1] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow, SantaCol + 1] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                    }
                    else if (matrix[SantaRow - 1, SantaCol] == '-')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow - 1, SantaCol] = 'S';
                        SantaRow -= 1;
                    }
                }
                else if (command == "down")
                {
                    if (SantaRow == rows - 1)
                    {
                        Console.WriteLine("Santa ran out of presents.");
                        matrix[SantaRow, SantaCol] = '-';
                        break;
                    }
                    if (matrix[SantaRow + 1, SantaCol] == 'X')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow + 1, SantaCol] = 'S';
                        SantaRow += 1;

                    }
                    else if (matrix[SantaRow + 1, SantaCol] == 'V')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow + 1, SantaCol] = 'S';
                        SantaRow += 1;
                        niceKidsCount--;
                        presentsCount--;
                    }
                    else if (matrix[SantaRow + 1, SantaCol] == 'C')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow + 1, SantaCol] = 'S';
                        SantaRow += 1;

                            if (matrix[SantaRow, SantaCol - 1] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow, SantaCol - 1] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow, SantaCol - 1] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }

                            if (matrix[SantaRow, SantaCol + 1] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow, SantaCol + 1] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow, SantaCol + 1] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }

                            if (matrix[SantaRow + 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow + 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow + 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                    }
                    else if (matrix[SantaRow + 1, SantaCol] == '-')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow + 1, SantaCol] = 'S';
                        SantaRow += 1;
                    }

                }
                else if (command == "left")
                {
                    if (SantaCol == 0)
                    {
                        Console.WriteLine("Santa ran out of presents.");
                        matrix[SantaRow, SantaCol] = '-';
                        break;
                    }
                    if (matrix[SantaRow, SantaCol - 1] == 'X')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol - 1] = 'S';
                        SantaCol -= 1;

                    }
                    else if (matrix[SantaRow, SantaCol - 1] == 'V')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol - 1] = 'S';
                        SantaCol -= 1;
                        niceKidsCount--;
                        presentsCount--;
                    }

                    else if (matrix[SantaRow, SantaCol - 1] == 'C')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol - 1] = 'S';
                        SantaCol -= 1;

                            if (matrix[SantaRow, SantaCol - 1] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow, SantaCol - 1] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow, SantaCol - 1] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                        
                            if (matrix[SantaRow - 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow - 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow - 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                        
                            if (matrix[SantaRow + 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow + 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow + 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                    }
                    else if (matrix[SantaRow, SantaCol - 1] == '-')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol - 1] = 'S';
                        SantaCol -= 1;
                    }

                }
                else if (command == "right")
                {
                    if (SantaCol == cols - 1)
                    {
                        Console.WriteLine("Santa ran out of presents.");
                        matrix[SantaRow, SantaCol] = '-';
                        break;
                    }
                    if (matrix[SantaRow, SantaCol + 1] == 'X')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol + 1] = 'S';
                        SantaCol += 1;


                    }
                    else if (matrix[SantaRow, SantaCol + 1] == 'V')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol + 1] = 'S';
                        SantaCol += 1;
                        niceKidsCount--;
                        presentsCount--;
                    }
                    else if (matrix[SantaRow, SantaCol + 1] == 'C')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol + 1] = 'S';
                        SantaCol += 1;

                            if (matrix[SantaRow, SantaCol + 1] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow, SantaCol + 1] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow, SantaCol + 1] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                        
                            if (matrix[SantaRow - 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow - 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow - 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                        
                            if (matrix[SantaRow + 1, SantaCol] == 'X')
                            {
                                presentsCount--;

                            }
                            else if (matrix[SantaRow + 1, SantaCol] == 'V')
                            {
                                presentsCount--;
                                niceKidsCount--;
                            }
                            matrix[SantaRow + 1, SantaCol] = '-';

                            if (presentsCount == 0)
                            {
                                break;
                            }
                        
                    }
                    else if (matrix[SantaRow, SantaCol + 1] == '-')
                    {
                        matrix[SantaRow, SantaCol] = '-';
                        matrix[SantaRow, SantaCol + 1] = 'S';
                        SantaCol += 1;


                    }
                }
                command = Console.ReadLine();
            }

            if (presentsCount == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            if (niceKidsCount == 0)
            {
                Console.WriteLine($"Good job, Santa! {TotalGoodKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No present for {niceKidsCount} nice kid/s.");
            }
        }
    }
}
