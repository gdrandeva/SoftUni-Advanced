using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] rectangularMatrix = new int[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                int[] rowsData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    rectangularMatrix[i, j] = rowsData[j];
                }
            }




            
            
            int maxSum = 0;
            int sum = 0;
            int startWithRow = default(int);
            int startWithCol = default(int);


            for (int row = 0; row < rectangularMatrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < rectangularMatrix.GetLength(1) - 2; col++)
                {
                    sum = 0;

                    sum += rectangularMatrix[row, col] + rectangularMatrix[row, col + 1] + rectangularMatrix[row, col + 2]
                        + rectangularMatrix[row + 1, col] + rectangularMatrix[row + 1, col + 1] + rectangularMatrix[row + 1, col + 2]
                        + rectangularMatrix[row + 2, col] + rectangularMatrix[row + 2, col + 1] + rectangularMatrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        startWithRow = row;
                        startWithCol = col;
                        maxSum = sum;
                    }
                }

            }




            Console.WriteLine($"Sum = {maxSum}");

            for (int i = startWithRow; i < startWithRow+3; i++)
            {
                for (int j = startWithCol; j < startWithCol+3; j++)
                {
                    Console.Write($"{rectangularMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
            //Console.Write($"{rectangularMatrix[startWithRow,startWithCol]} {rectangularMatrix[startWithRow, startWithCol+1]} {rectangularMatrix[startWithRow, startWithCol+2]}");
            //Console.WriteLine();
            //Console.Write($"{rectangularMatrix[startWithRow+1, startWithCol]} {rectangularMatrix[startWithRow+1, startWithCol + 1]} {rectangularMatrix[startWithRow+1, startWithCol + 2]}");
            //Console.WriteLine();
            //Console.Write($"{rectangularMatrix[startWithRow + 2, startWithCol]} {rectangularMatrix[startWithRow + 2, startWithCol + 1]} {rectangularMatrix[startWithRow + 2, startWithCol + 2]}");
        }
    }
}
