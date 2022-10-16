using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];

            for (int row = 0; row < size; row++)
            {
                int[] columnsByRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int column = 0; column < size; column++)
                {
                    matrix[row, column] = columnsByRow[column];
                }
            }
            int primaryDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        primaryDiagonalSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(primaryDiagonalSum);
        }
    }
}
