using System;

namespace _02._Truffle_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size,size];

            int currentRow = 0;
            int currentCol = 0;
            int oldRow = 0;
            int oldCol = 0;
            int blackCount = 0;
            int whiteCount = 0;
            int summerCount = 0;

            //fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = string.Join("", Console.ReadLine().Split()).ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = rowData[col];

                  
                }
            }

            string command = Console.ReadLine();

            while (command!="Stop the hunt")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                int row = 0; // int.Parse(tokens[1]);
                int col = 0; // int.Parse(tokens[2]);
                string direction;

                switch (cmd)
                {
                    case "Collect":
                        row = int.Parse(tokens[1]);
                        col = int.Parse(tokens[2]);
                        currentRow = row;
                        currentCol = col;
                        if (matrix[currentRow,currentCol] == 'B')
                        {
                            blackCount++;
                        
                        }
                        else if (matrix[currentRow, currentCol] == 'S')
                        {
                            summerCount++;
                        }
                        else if (matrix[currentRow, currentCol] == 'W')
                        {
                            whiteCount++;
                        }
                        else
                        {

                        }
                        oldRow = currentRow;
                        oldCol = currentCol;
                        matrix[currentRow, currentCol] = '-';


                        break;
                    case "Wild_Boar":
                    default:
                        break;
                }



                command = Console.ReadLine();
            }


        }
    }
}
