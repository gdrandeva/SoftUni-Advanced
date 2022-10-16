using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[size][];

            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                pascalTriangle[i] = new long[i+1] ;
                
                for (int col = 0; col < pascalTriangle[i].Length; col++)
                {
                    if (i==0)
                    {
                        pascalTriangle[i][col] = 1;
                        continue;
                    }
                    long currentValue = 0;
                    if (col>0 && i>0)
                    {
                        currentValue += pascalTriangle[i - 1][col - 1];
                    }

                    if (pascalTriangle[i].Length-1 > col )
                    {
                        currentValue += pascalTriangle[i - 1][col];
                    }

                    pascalTriangle[i][col] = currentValue;
                }
            }
            for (int k = 0; k < pascalTriangle.Length; k++)
            {
                for (int l = 0; l < pascalTriangle[k].Length; l++)
                {
                    Console.Write($"{pascalTriangle[k][l]} "); 
                }
                Console.WriteLine();
            }
        }
    }
}
