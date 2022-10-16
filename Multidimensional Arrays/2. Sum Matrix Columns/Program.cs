using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsColumns = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsColumns[0];
            int columns = rowsColumns[1];
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                int[] columnsData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = columnsData[j];
                }
            }
            int sum = 0;
            for (int k = 0; k < columns; k++)
            {
                sum = 0;
                for (int l = 0; l < rows; l++)
                {
                    sum += matrix[l,k];
                }
                    Console.WriteLine(sum);
            }
        }
    }
}
