using System;

namespace ConsoleApp3
{
    class Program
    {
        public static int currentRow = 0;
        public static int currentCol = 0;
        public static int oldRow = 0;
        public static int oldCol = 0;
        public static int points = 0;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            int firstRowS = 0;
            int secondRowS = 0;
            int secondColS = 0;
            int firstColS = 0;


            // fill the matrix
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


                }
            }

            //reading commands

            
            
           
            string command = Console.ReadLine();

            while (command != "End" || points >= 25)
            {

                switch (command)
                {
                    case "up":
                        if (IsValidCell(currentRow - 1, currentCol, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentRow--;
                            points=MoveMole(currentRow, currentCol, field, oldRow,oldCol, points,firstRowS,firstColS,secondRowS,secondColS);
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;
                    case "down":
                        if (IsValidCell(currentRow + 1, currentCol, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentRow++;
                            points = MoveMole(currentRow, currentCol, field, oldRow, oldCol, points, firstRowS, firstColS, secondRowS, secondColS);
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "left":
                        if (IsValidCell(currentRow, currentCol-1, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentCol--;
                           points =  MoveMole(currentRow, currentCol, field, oldRow, oldCol, points, firstRowS, firstColS, secondRowS, secondColS);
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "right":
                        if (IsValidCell(currentRow, currentCol + 1, field))
                        {
                            oldRow = currentRow;
                            oldCol = currentCol;
                            currentCol++;
                            points = MoveMole(currentRow, currentCol, field, oldRow, oldCol, points, firstRowS, firstColS, secondRowS, secondColS);
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
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

            if (!IsValidCell(currentRow, currentRow, field))
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

        static bool IsValidCell(int currentRow, int currentCol, char[,] field)
        {
            return currentRow >= 0 && currentRow < field.GetLength(0)
                    && currentCol >= 0 && currentCol < field.GetLength(1);

        }



        static int MoveMole(int currentRow, int currentCol, char[,] field, int oldRow, int oldCol, int points, int firstRowS, int firstColS, int secondRowS,int secondColS)
        {
            
            
            if (field[currentRow, currentCol] == '-')
            { 
                
                field[oldRow, oldCol] = '-';
                field[currentRow, currentCol] = 'M';
            }
            else if (field[currentRow, currentCol] == 'S')
            {
                field[currentRow, currentCol] = '-';
                field[oldRow, oldCol] = '-';

                for (int row = 0; row < field.GetLength(0); row++)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        if (field[row,col]=='S')
                        {
                           
                            currentRow = row;
                            currentCol = col;
                            points -= 3;
                            field[currentRow, currentCol] = 'M';
                            break; 
                        }
                    }
                }
                
                

            }
            else if (Char.IsDigit(field[currentRow, currentCol]))
            {
                points += int.Parse(field[currentRow, currentCol].ToString());
                field[oldRow, oldCol] = '-';
                field[currentRow, currentCol] = 'M';
            }
            return points;
        }







        //static void FindSpecialSLocation(char[,] field, int size, int firstRowS, int secondRowS, int secondColS, int firstColS)
        //{
        //    for (int i = 0; i < field.GetLength(0); i++)
        //    {
        //        for (int j = 0; j<field.GetLength(1); j++)
        //        {
        //            if (field[i, j] == 'S')
        //            {
        //                if (firstRowS == 0 && firstColS == 0)
        //                {
        //                    firstRowS = i;
        //                    firstColS = j;
        //                }
        //                else
        //                {
        //                    secondRowS = i;
        //                    secondColS = j;
        //                }

        //            }
        //        }
        //    }
        //}

    }
}
