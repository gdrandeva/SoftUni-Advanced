using System;
using System.Windows.Input;

namespace BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size,size];

            int currentRow = 0;
            int currentCol = 0;
            int oldRow = 0;
            int oldCol = 0;
            int woodCount = 0;
            int startIndex;
            int endIndex;

            for (int row = 0; row < size; row++)
            {
                char[] rowData = string.Join("",Console.ReadLine().Split()).ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row,col]=='B')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command!="end")
            {
                switch (command)
                {
                    case "up":
                        oldRow = currentRow;
                        oldCol = currentCol;
                        currentRow--;
                        if (!IsValidCell(currentRow, currentCol, matrix) && woodCount > 0)
                        {
                            woodCount--;

                        }
                        else if (Char.IsLower(matrix[currentRow, currentCol]))
                        {
                            woodCount++;
                            matrix[oldRow, oldCol] = '-';
                            matrix[currentRow, currentCol] = 'B';
                        }
                        else if (matrix[currentRow, currentCol] == 'F')
                        {
                            if (currentRow!=0)
                            {
                                for (int i = currentRow; i >= 0; i--)
                                {
                                    matrix[i, currentCol] = '-';
                                }
                            }
                            else
                            {
                                for (int i = currentRow; i <= size-1; i++)
                                {
                                    matrix[i, currentCol] = '-';
                                }
                            }
                        }
                       

                        break;
                    case "down":
                        oldRow = currentRow;
                        oldCol = currentCol;
                        currentRow++;
                        if (!IsValidCell(currentRow, currentCol, matrix) && woodCount > 0)
                        {
                            woodCount--;

                        }
                        else if (Char.IsLower(matrix[currentRow, currentCol]))
                        {
                            woodCount++;
                            matrix[oldRow, oldCol] = '-';
                            matrix[currentRow, currentCol] = 'B';
                        }
                        else if (matrix[currentRow, currentCol] == 'F')
                        {
                            if (currentRow != 0)
                            {
                                for (int i = currentRow; i < size; i++)
                                {
                                    matrix[i, currentCol] = '-';
                                }
                            }
                            else
                            {
                                for (int i = currentRow; i <= size - 1; i++)
                                {
                                    matrix[i, currentCol] = '-';
                                }
                            }
                        }
                        
                        break;
                    case "right":
                        oldRow = currentRow;
                        oldCol = currentCol;
                        currentCol++;
                        if (!IsValidCell(currentRow, currentCol, matrix) && woodCount > 0)
                        {
                            woodCount--;
                            
                        }
                        else if (Char.IsLower(matrix[currentRow, currentCol]))
                        {
                            woodCount++;
                            matrix[oldRow, oldCol] = '-';
                            matrix[currentRow, currentCol] = 'B';
                        }
                        else if (matrix[currentRow, currentCol] == 'F')
                        {
                            if (currentCol != 0)
                            {
                                for (int i = currentCol; i < size; i++)
                                {
                                    matrix[currentRow, i] = '-';
                                }
                            }
                            else
                            {
                                for (int i = currentCol; i >= 0; i--)
                                {
                                    matrix[currentRow, i] = '-';
                                }
                            }
                        }
                        
                        
                        break;
                    case "left":
                        oldRow = currentRow;
                        oldCol = currentCol;
                        currentCol--;
                        if (!IsValidCell(currentRow, currentCol, matrix) && woodCount > 0)
                        {
                            woodCount--;

                        }
                        else if (Char.IsLower(matrix[currentRow, currentCol]))
                        {
                            woodCount++;
                            matrix[oldRow, oldCol] = '-';
                            matrix[currentRow, currentCol] = 'B';
                        }
                        else if (matrix[currentRow, currentCol] == 'F')
                        {
                            if (currentCol != 0)
                            {
                                for (int i = currentCol; i >=0; i--)
                                {
                                    matrix[currentRow, i] = '-';
                                }
                            }
                            else
                            {
                                for (int i = currentCol; i < size; i--)
                                {
                                    matrix[currentRow, i] = '-';
                                }
                            }
                        }
                      
                        break;
                    default:
                        break;
                }

                Console.WriteLine("-------------------");

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(matrix[i,j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("-------------------");



                command = Console.ReadLine();
            }



        }
        static bool IsValidCell(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);

        }
    }
}

