using System;

namespace BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int currentRow = 0;
            int currentCol = 0;
            int oldRow = 0;
            int oldCol = 0;
            



            //fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = string.Join("", Console.ReadLine().Split()).ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];


                }
            }

        }
    }
}
