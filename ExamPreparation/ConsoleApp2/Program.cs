using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = 8;
            char[,] chessboard = new char[side,side];

            int whiteRow = 0;
            int whiteCol = 0;
            int blackRow = 0;
            int blackCol = 0;

            for (int row = 0; row < side; row++)
            {
                string rowElements = Console.ReadLine();
                for (int col = 0; col < side; col++)
                {
                    chessboard[row, col] = rowElements[col];

                    if (rowElements[col]=='w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                    if (rowElements[col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                }
            }


            bool whiteTurn = true;

            while (true)
            {
                if (whiteTurn)
                {
                    if (whiteRow==0)
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(97+whiteCol)}8.");
                        return;
                    }

                    if (IsValidCell(whiteRow-1,whiteCol-1,chessboard) && chessboard[whiteRow-1,whiteCol-1]=='b')
                    {
                        whiteRow--;
                        whiteCol--;

                        Console.WriteLine($"Game over! White capture on {(char)(97 + whiteCol)}{8-whiteRow}.");
                        return;
                    }
                    if (IsValidCell(whiteRow - 1, whiteCol + 1, chessboard) && chessboard[whiteRow - 1, whiteCol + 1] == 'b')
                    {
                        whiteRow--;
                        whiteCol++;

                        Console.WriteLine($"Game over! White capture on {(char)(97 + whiteCol)}{8 - whiteRow}.");
                        return;
                    }

                    whiteRow--;
                    chessboard[whiteRow, whiteCol] = 'w';
                }
                else
                {
                    if (blackRow == 7)
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(97 + blackCol)}1.");
                        return;
                    }

                    if (IsValidCell(blackRow + 1, blackCol - 1, chessboard) && chessboard[blackCol + 1, blackCol - 1] == 'w')
                    {
                        blackCol--;
                        blackRow++;

                        Console.WriteLine($"Game over! Black capture on {(char)(97 + blackCol)}{8 - blackRow}.");
                        return;
                    }
                    if (IsValidCell(blackRow + 1, blackCol + 1, chessboard) && chessboard[blackRow + 1, blackCol + 1] == 'w')
                    {
                        blackCol++;
                        blackRow++;

                        Console.WriteLine($"Game over! Black capture on {(char)(97 + blackCol)}{8 - blackRow}.");
                        return;
                    }


                    blackRow++; 
                    chessboard[blackRow, blackCol] = 'b';
                }

                whiteTurn = !whiteTurn;
                
            }
        }
        static bool IsValidCell(int row, int col, char[,] matrix)
        {
            return row >= 0
                    && row < matrix.GetLength(0)
                    && col >= 0
                    && col < matrix.GetLength(1);
        
        }
    }
}
