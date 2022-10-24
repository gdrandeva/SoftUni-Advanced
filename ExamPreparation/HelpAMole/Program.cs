using System;

namespace HelpAMole
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];
            int currentRow = 0;
            int currentCol = 0;
            int points = 0;
            int firstSRow = 0;
            int firstSCol = 0;
            int secondSRow = 0;
            int secondSCol = 0;

            for (int row = 0; row < size; row++)
            {
                string rowsData = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowsData[col];

                    if (rowsData[col] == 'M')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    //if (rowsData[col] == 'S')
                    //{
                    //    if (firstSRow==0 && firstSCol==0)
                    //    {
                    //    firstSRow = row;
                    //    firstSCol = col;

                    //    }
                    //    else
                    //    {
                    //        secondSRow = row;
                    //        secondSCol = col;
                    //    }
                    //}
                }
            }

             
            
            
            
            
            
            
            
            
            
            
            
            string command = Console.ReadLine();

            while (command != "End" || points>=25)
            {
                int oldRow = 0;
                int oldCol = 0;
                switch (command)
                {
                    case "up":
                        if (IsValidLocation(currentRow - 1, currentCol, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentRow--;
                          points= MoveMole(currentRow, currentCol, oldRow, oldCol, points, field);
                            Console.WriteLine("---------------------------------------------------------------");

                            for (int i = 0; i < size; i++)
                            {
                                for (int j = 0; j < size; j++)
                                {
                                    Console.Write(field[i,j]);
                                }
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------------");

                           
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "down":
                        if (IsValidLocation(currentRow + 1, currentCol,  field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentRow++;
                            points = MoveMole(currentRow, currentCol, oldRow, oldCol, points, field);
                            Console.WriteLine("---------------------------------------------------------------");

                            for (int i = 0; i < size; i++)
                            {
                                for (int j = 0; j < size; j++)
                                {
                                    Console.Write(field[i, j]);
                                }
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------------");

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "left":
                        if (IsValidLocation(currentRow, currentCol-1, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentCol--;
                            points = MoveMole(currentRow, currentCol, oldRow, oldCol, points, field);
                            Console.WriteLine("---------------------------------------------------------------");

                            for (int i = 0; i < size; i++)
                            {
                                for (int j = 0; j < size; j++)
                                {
                                    Console.Write(field[i, j]);
                                }
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------------");

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "right":
                        if (IsValidLocation(currentRow, currentCol + 1, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentCol++;
                            points=MoveMole(currentRow, currentCol, oldRow, oldCol, points, field);
                            Console.WriteLine("---------------------------------------------------------------");

                            for (int i = 0; i < size; i++)
                            {
                                for (int j = 0; j < size; j++)
                                {
                                    Console.Write(field[i, j]);
                                }
                                Console.WriteLine();
                            }


                            Console.WriteLine("---------------------------------------------------------------");

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
            }

            if (!IsValidLocation(currentRow, currentRow, field))
            {
                Console.WriteLine("Don't try to escape the playing field!");
            }

            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
        static bool IsValidLocation(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }

        static int MoveMole(int row, int col, int oldRow, int oldCol, int points,char[,] field, int firstSRow=0, int firstSCol=0, int secondSRow= 0, int secondSCol = 0 )
        {
           
            if (char.IsDigit(field[row, col]))
            {
                points += field[row, col];
                field[oldRow, oldCol] = '-';
                field[row, col] = 'M';
            }
            else if (field[row, col] == 'S')
            {
                if (firstSRow == 0 && firstSCol == 0)
                {
                    firstSRow = row;
                    firstSCol = col;

                }
                else
                {
                    secondSRow = row;
                    secondSCol = col;
                }
                row += row;
                col += col;
                field[oldRow, oldCol] = '-';
                field[row, col] = 'M';
                points -= 3;


                for (int i = 0; i < field.GetLength(0); i++)
                {

                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == 'S')
                        {
                            field[row, col] = '-';
                            field[i, j] = 'M';


                            break;

                        }
                        
                    }
                    break;
                }

            }
            else
            {
                field[oldRow, oldCol] = '-';
                field[row, col] = 'M';
            }
               return (int)points;
        }

        

    }
}