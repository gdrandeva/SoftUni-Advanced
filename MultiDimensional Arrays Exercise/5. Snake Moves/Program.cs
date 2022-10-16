using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            string input = Console.ReadLine();

            int currentWordIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentWordIndex == input.Length)
                        {
                            currentWordIndex = 0;
                        }
                        matrix[row, col] = input[currentWordIndex];
                        currentWordIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        if (currentWordIndex == input.Length)
                        {
                            currentWordIndex = 0;
                        }
                        matrix[row, col] = input[currentWordIndex];
                currentWordIndex++;
                    }
                }
                
                    
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
