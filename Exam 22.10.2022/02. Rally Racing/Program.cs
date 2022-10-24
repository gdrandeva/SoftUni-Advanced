using System;

namespace _02._Rally_Racing
{
    class Program
    {
        private static int carRow;
        private static int carCol;
        private static int startTunnelRow = int.MaxValue;
        private static int startTunnelCol;
        private static int endTunnelRow;
        private static int endTunnelCol;
        private static int finishRow;
        private static int finishCol;
        private static int oldRow;
        private static int oldCol;

        private static char[,] matrix;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int racingNumber = int.Parse(Console.ReadLine());
            string number = racingNumber.ToString().PadLeft(2, '0');

            matrix = new char[size,size];


            for (int row = 0; row < size; row++)
            {
                char[] rowData = string.Join("", Console.ReadLine().Split()).ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];


                    if (rowData[col]=='T' && startTunnelRow==int.MaxValue)
                    {
                        startTunnelRow = row;
                        startTunnelCol = col;
                    }
                    else if (rowData[col] == 'T' && startTunnelRow != int.MaxValue)
                    {
                        endTunnelRow = row;
                        endTunnelCol = col;
                    }
                    else if (rowData[col] == 'F')
                    {
                        finishRow = row;
                        finishCol = col;
                    }
                }
            }

            //read the matrix
            

            
            
            int distance = 0;
            carRow = 0;
            carCol = 0;
            

            
            
            string command = Console.ReadLine();

            while (command !="End")
            {
                switch (command)
                {
                    case "left":
                        
                        oldRow = carRow;
                        oldCol = carCol;
                        carCol--;
                        if (IsValidCell(carRow,carCol))
                        {


                            if (matrix[carRow, carCol] == 'T')
                            {
                                matrix[carRow, carCol] = '.';
                                matrix[oldRow, oldCol] = '.';

                                if (carRow != startTunnelRow && carCol != startTunnelCol)
                                {
                                    carRow = startTunnelRow;
                                    carCol = startTunnelCol;

                                }
                                else
                                {
                                    carRow = endTunnelRow;
                                    carCol = endTunnelCol;
                                }

                                matrix[carRow, carCol] = '.';
                                distance += 30;
                            }
                            else if (matrix[carRow, carCol] == 'F')
                            {
                                matrix[carRow, carCol] = 'C';
                                distance += 10;
                                Console.WriteLine($"Racing car {number} finished the stage!");
                                Console.WriteLine($"Distance covered {distance} km.");
                                for (int k = 0; k < size; k++)
                                {
                                    for (int l = 0; l < size; l++)
                                    {
                                        Console.Write($"{matrix[k, l]}");
                                    }
                                    Console.WriteLine();
                                }
                                return;
                            }
                            else
                            {
                                distance += 10;
                            }

                        }
                        break;
                    case "right":
                        oldRow = carRow;
                        oldCol = carCol;
                        carCol++;
                        if (IsValidCell(carRow, carCol))
                        {
                            

                            if (matrix[carRow, carCol] == 'T')
                            {
                                matrix[carRow, carCol] = '.';
                                matrix[oldRow, oldCol] = '.';

                                if (carRow != startTunnelRow && carCol != startTunnelCol)
                                {
                                    carRow = startTunnelRow;
                                    carCol = startTunnelCol;
                                    
                                }
                                else
                                {
                                    carRow = endTunnelRow;
                                    carCol = endTunnelCol;
                                }

                                matrix[carRow, carCol] = '.';
                                distance += 30;
                            }
                            else if (matrix[carRow, carCol] == 'F')
                            {
                                matrix[carRow, carCol] = 'C';
                                distance += 10;
                                Console.WriteLine($"Racing car {number} finished the stage!");
                                Console.WriteLine($"Distance covered {distance} km.");

                                for (int k = 0; k < size; k++)
                                {
                                    for (int l = 0; l < size; l++)
                                    {
                                        Console.Write($"{matrix[k, l]}");
                                    }
                                    Console.WriteLine();
                                }
                                return;
                            }
                            else
                            {
                                distance += 10;
                            }

                        }
                        break;
                    case "up":
                        oldRow = carRow;
                        oldCol = carCol;
                        carRow--;
                        if (IsValidCell(carRow, carCol))
                        {


                            if (matrix[carRow, carCol] == 'T')
                            {
                                matrix[carRow, carCol] = '.';
                                matrix[oldRow, oldCol] = '.';

                                if (carRow != startTunnelRow && carCol != startTunnelCol)
                                {
                                    carRow = startTunnelRow;
                                    carCol = startTunnelCol;

                                }
                                else
                                {
                                    carRow = endTunnelRow;
                                    carCol = endTunnelCol;
                                }

                                matrix[carRow, carCol] = '.';
                                distance += 30;
                            }
                            else if (matrix[carRow, carCol] == 'F')
                            {
                                matrix[carRow, carCol] = 'C';
                                distance += 10;
                                Console.WriteLine($"Racing car {number} finished the stage!");
                                Console.WriteLine($"Distance covered {distance} km.");

                                for (int k = 0; k < size; k++)
                                {
                                    for (int l = 0; l < size; l++)
                                    {
                                        Console.Write($"{matrix[k, l]}");
                                    }
                                    Console.WriteLine();
                                }
                                return;
                            }
                            else
                            {
                                distance += 10;
                            }

                        }
                        break;
                    case "down":
                        oldRow = carRow;
                        oldCol = carCol;
                        carRow++;
                        if (IsValidCell(carRow, carCol))
                        {


                            if (matrix[carRow, carCol] == 'T')
                            {
                                matrix[carRow, carCol] = '.';
                                matrix[oldRow, oldCol] = '.';

                                if (carRow != startTunnelRow && carCol != startTunnelCol)
                                {
                                    carRow = startTunnelRow;
                                    carCol = startTunnelCol;

                                }
                                else
                                {
                                    carRow = endTunnelRow;
                                    carCol = endTunnelCol;
                                }

                                matrix[carRow, carCol] = '.';
                                distance += 30;
                            }
                            else if (matrix[carRow, carCol] == 'F')
                            {
                                matrix[carRow, carCol] = 'C';
                                distance += 10;
                                Console.WriteLine($"Racing car {number} finished the stage!");
                                Console.WriteLine($"Distance covered {distance} km.");

                                for (int k = 0; k < size; k++)
                                {
                                    for (int l = 0; l < size; l++)
                                    {
                                        Console.Write($"{matrix[k, l]}");
                                    }
                                    Console.WriteLine();
                                }
                                return;
                            }
                            else
                            {
                                distance += 10;
                            }
                        }
                            break;
                        
                    
                }

                //Console.WriteLine("-------------------------------");

                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        Console.Write(matrix[i, j]);
                //    }
                //    Console.WriteLine();
                //}


                //Console.WriteLine("-------------------------------");

                command = Console.ReadLine();
            }

            //if (matrix[oldRow,oldCol]=='F')
            //{
            //    Console.WriteLine($"Racing car {racingNumber.ToString().PadLeft(1, '0')} finished the stage!");
            //}


            if (command=="End")
            {
            Console.WriteLine($"Racing car {number} DNF.");

            }
            Console.WriteLine($"Distance covered {distance} km.");
            matrix[carRow, carCol] = 'C';

            for (int k = 0; k < size; k++)
            {
                for (int l = 0; l < size; l++)
                {
                    Console.Write($"{matrix[k,l]}");
                }
                Console.WriteLine();
            }

        }


        public static bool IsValidCell(int carRow, int carCol)
        {
            return carRow >= 0 && carRow < matrix.GetLength(0)
                    && carCol >= 0 && carCol < matrix.GetLength(1);
        }
    }
}
