using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
           
            char[,] matrix = new char[matrixSize,matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string columnsByRow = Console.ReadLine();
                

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = columnsByRow[col];
                }
            }
            char specialSymbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (specialSymbol==matrix[i,j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{specialSymbol} does not occur in the matrix ");

        }
    }
}
