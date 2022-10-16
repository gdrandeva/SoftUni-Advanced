using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] columnsByRow = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = columnsByRow[col];
                }
            }


            int maxSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < matrixSize[0]-2+1; i++)
            {
                for (int j = 0; j < matrixSize[1] - 2+1; j++)
                {
                    int sum = 0;
                    sum += matrix[i, j];
                    sum += matrix[i+1, j];
                    sum += matrix[i, j+1];
                    sum += matrix[i+1, j+1];
                if (sum>maxSum)
                {
                        startIndex = i;
                        endIndex = j;
                        maxSum = sum;
                }
                }
            }
            Console.WriteLine($"{matrix[startIndex,endIndex]} {matrix[startIndex,endIndex+1]}");
            Console.WriteLine($"{matrix[startIndex+1,endIndex]} {matrix[startIndex+1,endIndex+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
