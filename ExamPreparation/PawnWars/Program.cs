using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 8;

            char[,] chessboard = new char[SIZE,SIZE];
            int whiteRow = 0;
            int whiteCol = 0;
            int blackRow = 0;
            int blackCol = 0;

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                string rowsData = Console.ReadLine();
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = rowsData[col];
                    if (chessboard[row, col]=='w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                    if (chessboard[row, col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }

                }

            }

            for (
                
                int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    int oldRowW = whiteRow;
                    int oldColW = whiteCol;
                    int oldRowB = blackRow;
                    int oldColB = blackCol;
                        
                    if (col%2==0)
                    {
                        if (whiteRow == 0)
                        {
                            Console.WriteLine($"Game over! White pawn is promoted to a queen at {whiteRow}{whiteCol}.");
                        }
                        if (whiteRow >0 && whiteRow<7)
                        {

                        
                        
                        if (chessboard[whiteRow + 1, whiteCol + 1] == 'b' || chessboard[whiteRow + 1, whiteCol - 1] == 'b'
                           || chessboard[whiteRow - 1, whiteCol + 1] == 'b' || chessboard[whiteRow - 1, whiteCol - 1] == 'b')
                        {
                            Console.WriteLine($"Game over! White capture on {whiteRow}{whiteCol}.");
                        }
                        
                        else if (whiteRow>0 && whiteRow<SIZE-1)
                        {
                            whiteRow--;
                            chessboard[oldRowW, oldColW] = '-';
                        chessboard[whiteRow, whiteCol] = 'w';

                        }
                        }



                    }
                    else
                    {
                        if (blackRow == 7)
                        {
                            Console.WriteLine($"Game over! Black pawn is promoted to a queen at {blackRow}{blackCol}.");
                        }

                        if (blackRow>0 && blackRow<7)
                        {
                            
                        
                      
                        if (chessboard[blackRow + 1, blackCol + 1] == 'w' || chessboard[blackRow + 1, blackCol - 1] == 'w'
                            || chessboard[blackRow - 1, blackCol + 1] == 'w' || chessboard[blackRow - 1, blackCol - 1] == 'w')
                        {
                            Console.WriteLine($"Game over! Black capture on {blackRow}{blackCol}.");
                        }
                        
                       else if (blackRow > 0 && blackRow < SIZE-1)
                        {
                            blackRow++;
                            chessboard[oldRowB, oldColB] = '-';
                            chessboard[blackRow, blackCol] = 'b';
                        }

                        }


                    }


                }
            }
                Console.WriteLine();

        }
    }
}
