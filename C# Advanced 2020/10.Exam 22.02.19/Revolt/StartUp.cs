using System;

namespace Revolt
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int countofCommands = int.Parse(Console.ReadLine());

            int rows = dimension;
            int cols = dimension;

            int playerRow = 0;
            int playerCol = 0;
            int finalRow = 0;
            int finalCol = 0;
            
            int counterB = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if(currentRow[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    else if(currentRow[col] == 'F')
                    {
                        finalRow = row;
                        finalCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            int counter = 0;

            while (true)
            {
                counter++;

                if (command == "up")
                {
                    if(playerRow - 1 < 0)
                    {
                        matrix[playerRow, playerCol] = '-';
                        
                        if(matrix[rows - 1,playerCol] == '-')
                        {
                            matrix[rows - 1, playerCol] = 'f';
                            playerRow =rows - 1;
                        }
                        else if(matrix[rows - 1, playerCol] == 'B')
                        {
                            //matrix[rows - 1, playerCol] = '-';
                            matrix[rows - 2, playerCol] = 'f';

                            playerRow = rows - 2;
                        }
                        else if(matrix[rows - 1,playerCol] == 'T')
                        {
                            //matrix[rows - 1, playerCol] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if(matrix[rows - 1,playerCol] == 'F')
                        {
                            matrix[rows - 1, playerCol] = 'f';
                            playerRow = rows - 1;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else if(playerRow - 1 >= 0)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[playerRow - 1, playerCol] == '-')
                        {
                            matrix[playerRow - 1, playerCol] = 'f';
                            playerRow -= 1;
                        }
                        else if (matrix[playerRow - 1, playerCol] == 'B')
                        {
                            //matrix[playerRow - 1, playerCol] = '-';
                            
                            matrix[rows - 1, playerCol] = 'f';

                            playerRow = rows - 1;
                        }
                        else if (matrix[rows - 1, playerCol] == 'T')
                        {
                            //matrix[rows - 1, playerCol] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[rows - 1, playerCol] == 'F')
                        {
                            matrix[rows - 1, playerCol] = 'f';
                            playerRow = rows - 1;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }
                else if(command == "down")
                {
                    if (playerRow + 1 > rows - 1)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[0, playerCol] == '-')
                        {
                            matrix[0, playerCol] = 'f';
                            playerRow = 0;
                        }
                        else if (matrix[0, playerCol] == 'B')
                        {
                            //matrix[0, playerCol] = '-';
                            matrix[1, playerCol] = 'f';

                            playerRow++;
                        }
                        else if (matrix[0, playerCol] == 'T')
                        {
                            //matrix[0, playerCol] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[0, playerCol] == 'F')
                        {
                            matrix[0, playerCol] = 'f';
                            playerRow = 0;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else if (playerRow + 1  <= rows - 1)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[playerRow + 1, playerCol] == '-')
                        {
                            matrix[playerRow + 1, playerCol] = 'f';
                            playerRow += 1;
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'B')
                        {
                            //matrix[playerRow + 1, playerCol] = '-';
                            matrix[0, playerCol] = 'f';

                            playerRow = 0;
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'T')
                        {
                            //matrix[playerRow + 1, playerCol] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'F')
                        {
                            matrix[playerRow + 1, playerCol] = 'f';
                            playerRow ++;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }
                else if(command == "left")
                {
                    if (playerCol - 1 < 0)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[playerRow, cols - 1] == '-')
                        {
                            matrix[playerRow, cols - 1] = 'f';
                            playerCol = cols - 1;
                        }
                        else if (matrix[playerRow, cols - 1] == 'B')
                        {
                            //matrix[playerRow, cols - 1] = '-';
                            matrix[playerRow, cols - 2] = 'f';

                            playerCol = cols - 2;
                        }
                        else if (matrix[playerRow, cols - 1] == 'T')
                        {
                           // matrix[playerRow, cols - 1] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, cols - 1] == 'F')
                        {
                            matrix[playerRow, cols - 1] = 'f';
                            playerCol = cols - 1;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else if(playerCol - 1 >= 0)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[playerRow, playerCol - 1] == '-')
                        {
                            matrix[playerRow, playerCol - 1] = 'f';
                            playerCol -= 1;
                        }
                        else if (matrix[playerRow, playerCol - 1] == 'B')
                        {
                            //matrix[playerRow, playerCol - 1] = '-';
                            
                            matrix[playerRow, cols - 1] = 'f';
                            
                            playerCol = cols - 1;
                        }
                        else if (matrix[playerRow, playerCol - 1] == 'T')
                        {
                            //matrix[playerRow, playerCol - 1] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol - 1] == 'F')
                        {
                            matrix[playerRow, playerCol - 1] = 'f';
                            playerRow++;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }
                else if(command == "right")
                {
                    if (playerCol + 1 > cols - 1)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[playerRow, 0] == '-')
                        {
                            matrix[playerRow, 0] = 'f';
                            playerCol = 0;
                        }
                        else if (matrix[playerRow, 0] == 'B')
                        {
                            //matrix[playerRow, 0] = '-';
                            matrix[playerRow, 1] = 'f';

                            playerCol++;
                        }
                        else if (matrix[playerRow, 0] == 'T')
                        {
                           // matrix[playerRow, 0] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, 0] == 'F')
                        {
                            matrix[playerRow, 0] = 'f';
                            playerCol = 0;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else if (playerCol + 1 <= cols - 1)
                    {
                        matrix[playerRow, playerCol] = '-';

                        if (matrix[playerRow, playerCol + 1] == '-')
                        {
                            matrix[playerRow, playerCol + 1] = 'f';
                            playerCol += 1;
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'B')
                        {
                            //matrix[playerRow, playerCol + 1] = '-';
                            matrix[playerRow, 0] = 'f';

                            playerCol = 0;
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'T')
                        {
                            //matrix[playerRow, playerCol + 1] = '-';
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'F')
                        {
                            matrix[playerRow, playerCol + 1] = 'f';
                            playerRow++;
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }


                
                if (counter == countofCommands && matrix[finalRow,finalCol] != 'f')
                {
                    Console.WriteLine("Player lost!");
                    break;
                }
                else if(counter == countofCommands && matrix[finalRow, finalCol] == 'f')
                {
                    Console.WriteLine("Player win!");
                    break;
                }

                command = Console.ReadLine();
            }

            for (int rol = 0; rol < rows; rol++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[rol,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
