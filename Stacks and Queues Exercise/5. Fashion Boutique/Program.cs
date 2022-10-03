using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothesStack = new Stack<int>(clothes);

            int sumClothes = 0;
            int racks = 0;

            while (clothesStack.Count>0)
            {
                if (sumClothes == rackCapacity && clothesStack.Count > 0)
                {
                    racks++;
                    sumClothes = 0;
                   
                    continue;

                }
                else
                {
                    if (sumClothes>rackCapacity)
                    {
                        racks++;
                        if (sumClothes-rackCapacity>0)
                        {
                            racks++;
                        }
                        sumClothes = 0;

                        continue;
                    }
                }
                sumClothes += clothesStack.Pop();
            }

            Console.WriteLine(racks);
            
            
        }
    }
}
