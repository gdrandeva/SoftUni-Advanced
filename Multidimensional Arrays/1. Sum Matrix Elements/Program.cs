using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsColumns = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsColumns[0];
            int columns = rowsColumns[1];
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] rowData = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(rowData[j]);
                }
            }
            
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            int sum = 0;
            foreach (var element in matrix)
            {

                sum += element;

            }
            Console.WriteLine(sum);
        }
    }
}
