using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int columns = size[1];

            int[,] matrix = new int[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                char[] rowsData = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i,j] = rowsData[j];
                }
            }

            int numberOfSubmatrix = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) -1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                       matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        numberOfSubmatrix++;
                    }
                   
                }
            }

                Console.WriteLine(numberOfSubmatrix);
            
        }
    }
}
