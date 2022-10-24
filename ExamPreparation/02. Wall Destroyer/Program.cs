using System;

namespace _02._Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = line[col];

                    if (line[col]=='V')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = Console.ReadLine().ToLower();
            int holes = 0;
            int rods = 0;
            matrix[currentRow, currentCol] = '*';
            bool isElectricuted = false;


            while (command!="end")
            {
                int oldRow = currentRow;
                int oldCol = currentCol;
                switch (command)
                {
                    case "up":
                        currentRow--;
                        break;
                    case "down":
                        currentRow++;
                        break;
                    case "left":
                        currentCol--;
                        break;
                    case "right":
                        currentCol++;
                        break;
                }

                if (currentRow>=0 || currentRow<size ||currentCol>=0 || currentCol<size)
                {
                    if (matrix[currentRow,currentCol]=='R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        currentRow = oldRow;
                        currentCol = oldCol;
                        rods++;
                    }
                    else if (matrix[currentRow,currentCol]=='-')
                    {
                        holes++;
                        matrix[currentRow, currentCol] = '*';
                    }
                    else if (matrix[currentRow,currentCol]=='*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                    }
                    else if (matrix[currentRow, currentCol]=='C')
                    {
                        isElectricuted = true;
                        holes++;
                        matrix[currentRow, currentCol] = 'E';
                        break;
                    }
                }
                else
                {
                    currentRow = oldRow;
                    currentCol = oldCol;
                }





                command = Console.ReadLine().ToLower();
            }

            if (isElectricuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
                matrix[currentRow, currentCol] = 'V';
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; row < matrix.GetLength(1); row++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }




        }
    }
}
