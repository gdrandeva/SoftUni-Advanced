using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] columnsByRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = columnsByRow[col];
                }
            }
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for ( int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i,i];
                secondaryDiagonalSum += matrix[i, n-i-1];
            }






            int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(difference);



        }
    }
}

