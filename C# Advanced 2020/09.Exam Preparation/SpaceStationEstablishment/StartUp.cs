using System;
using System.Linq;

namespace SpaceStationEstablishment
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int rows = dimension;
            int cols = dimension;

            int playerRow = 0;
            int playerCol = 0;

            int blackHoleRow = 0;
            int blackHoleCol = 0;


            int blackHole2Row = 0;
            int blackHole2Col = 0;

            int totalPower = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (currentRow[col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'O')
                    {

                        blackHoleRow = row;
                        blackHoleCol = col;

                        matrix[blackHoleRow, blackHoleCol] = '-';
                        row = rows;
                        break;

                    }

                }

            }
            for (int row2 = blackHoleRow; row2 < rows; row2++)
            {
                for (int col2 = 0; col2 < cols; col2++)
                {
                    if (matrix[row2, col2] == 'O')
                    {
                        blackHole2Row = row2;
                        blackHole2Col = col2;

                        matrix[blackHoleRow, blackHoleCol] = 'O';
                        break;
                    }

                }

            }

            string command = Console.ReadLine();

            while (true)
            {


                if (command == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        if (matrix[playerRow - 1, playerCol] != '-' && matrix[playerRow - 1, playerCol] != 'O')
                        {
                            totalPower += (int)(matrix[playerRow - 1, playerCol]) - 48;
                            matrix[playerRow - 1, playerCol] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerRow--;

                            if (totalPower >= 50)
                            {
                                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
                                Console.WriteLine($"Star power collected: {totalPower}");
                                break;
                            }

                        }
                        else if (matrix[playerRow - 1, playerCol] == 'O')
                        {
                            if (playerRow - 1 == blackHoleRow)
                            {
                                matrix[blackHole2Row, blackHole2Col] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHole2Row;
                                playerCol = blackHole2Col;

                                matrix[blackHoleRow, blackHoleCol] = '-';
                            }
                            else if (playerRow - 1 == blackHole2Row)
                            {
                                matrix[blackHole2Row, blackHole2Col] = '-';
                                matrix[blackHoleRow, blackHoleCol] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHoleRow;
                                playerCol = blackHoleCol;
                            }
                        }
                        else
                        {
                            matrix[playerRow - 1, playerCol] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerRow--;
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {totalPower}");
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 < rows)
                    {
                        if (matrix[playerRow + 1, playerCol] != '-' && matrix[playerRow + 1, playerCol] != 'O')
                        {
                            totalPower += (int)(matrix[playerRow + 1, playerCol]) - 48;
                            matrix[playerRow + 1, playerCol] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerRow++;

                            if (totalPower >= 50)
                            {
                                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
                                Console.WriteLine($"Star power collected: {totalPower}");
                                break;
                            }

                        }
                        else if (matrix[playerRow + 1, playerCol] == 'O')
                        {
                            if (playerRow + 1 == blackHoleRow)
                            {
                                matrix[blackHole2Row, blackHole2Col] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHole2Row;
                                playerCol = blackHole2Col;

                                matrix[blackHoleRow, blackHoleCol] = '-';
                            }
                            else if (playerRow + 1 == blackHole2Row)
                            {
                                matrix[blackHole2Row, blackHole2Col] = '-';
                                matrix[blackHoleRow, blackHoleCol] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHoleRow;
                                playerCol = blackHoleCol;
                            }
                        }
                        else
                        {
                            matrix[playerRow + 1, playerCol] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerRow++;
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {totalPower}");
                        break;
                    }
                }
                else if(command == "left")
                {
                    if(playerCol - 1 >= 0)
                    {
                        if (matrix[playerRow, playerCol - 1] != '-' && matrix[playerRow, playerCol - 1] != 'O')
                        {
                            totalPower += (int)(matrix[playerRow, playerCol - 1]) - 48;
                            matrix[playerRow, playerCol - 1] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerCol--;

                            if (totalPower >= 50)
                            {
                                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
                                Console.WriteLine($"Star power collected: {totalPower}");
                                break;
                            }
                        }
                        else if (matrix[playerRow , playerCol - 1] == 'O')
                        {
                            if (playerCol - 1 == blackHoleCol)
                            {
                                matrix[blackHole2Row, blackHole2Col] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHole2Row;
                                playerCol = blackHole2Col;

                                matrix[blackHoleRow, blackHoleCol] = '-';
                            }
                            else if (playerCol - 1 == blackHole2Col)
                            {
                                matrix[blackHole2Row, blackHole2Col] = '-';
                                matrix[blackHoleRow, blackHoleCol] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHoleRow;
                                playerCol = blackHoleCol;
                            }
                        }
                        else
                        {
                            matrix[playerRow, playerCol - 1] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerCol--;
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {totalPower}");
                        break;
                    }
                }
                else if(command == "right")
                {
                    if(playerCol + 1 < cols)
                    {
                        if (matrix[playerRow, playerCol + 1] != '-' && matrix[playerRow, playerCol + 1] != 'O')
                        {
                            totalPower += (int)(matrix[playerRow, playerCol + 1]) - 48;
                            matrix[playerRow, playerCol + 1] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerCol++;

                            if (totalPower >= 50)
                            {
                                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
                                Console.WriteLine($"Star power collected: {totalPower}");
                                break;
                            }
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'O')
                        {
                            if (playerCol + 1 == blackHoleCol)
                            {
                                matrix[blackHole2Row, blackHole2Col] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHole2Row;
                                playerCol = blackHole2Col;

                                matrix[blackHoleRow, blackHoleCol] = '-';
                            }
                            else if (playerCol + 1 == blackHole2Col)
                            {
                                matrix[blackHole2Row, blackHole2Col] = '-';
                                matrix[blackHoleRow, blackHoleCol] = 'S';
                                matrix[playerRow, playerCol] = '-';
                                playerRow = blackHoleRow;
                                playerCol = blackHoleCol;
                            }
                        }
                        else
                        {
                            matrix[playerRow, playerCol + 1] = 'S';
                            matrix[playerRow, playerCol] = '-';
                            playerCol++;
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {totalPower}");
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
            
        }
    }
}

