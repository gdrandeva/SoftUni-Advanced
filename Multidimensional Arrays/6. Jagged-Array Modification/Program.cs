using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[matrixRows,matrixRows];
            int[][] matrix = new int[matrixRows][];
            for (int row = 0; row < matrixRows; row++)
            {
                int[] columnsByRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

               
                    matrix[row]= columnsByRow;
                
            }

            
            while (true)
                {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }
                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        int row = int.Parse(tokens[1]);
                        int col = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);
                        if (row >=0 && row < matrix.Length && col>=0 && col<matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                            continue;
                        }
                        
                       
                        break; 
                    case "Subtract":
                        row = int.Parse(tokens[1]);
                        col = int.Parse(tokens[2]);
                        value = int.Parse(tokens[3]);
                        if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                            continue;
                        }



                        
                        break;
                    
                }
            }
            for (int k = 0; k < matrix.Length; k++)
            {
               
                for (int l = 0; l < matrix[k].Length; l++)
                {
                    Console.Write($"{matrix[k][l]} ");
                }
                Console.WriteLine();
            }

        }

    }
}
