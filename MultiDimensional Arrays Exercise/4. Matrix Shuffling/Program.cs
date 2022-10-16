using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToArray();

            string[,] matrix = new string[size[0],size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowsData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsData[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (IsValidCommand(size,tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                if (tokens.Length!=5 && !tokens[0].Contains("swap"))
                {
                    continue;
                }

               

            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            
           for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidCommand(int[] size, string[] tokens)
        {

            bool isValidCmd =
            tokens[0] == "swap"
            && tokens.Length == 5
            && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < size[0]
            && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < size[1]
            && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < size[0]
            && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < size[1];

            return isValidCmd;


        }

      
    }
}
