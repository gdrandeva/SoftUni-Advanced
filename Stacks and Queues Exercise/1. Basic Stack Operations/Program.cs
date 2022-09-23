using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int stackPush = numbers[0];
            int stackPop = numbers[1];
            int stackFind = numbers[2];

            int[] givenArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < stackPush; i++)
            {
                nums.Push(givenArr[i]);
            }
            for (int i = 0; i < stackPop; i++)
            {
                nums.Pop();
            }
            if (nums.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (nums.Contains(stackFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNum = nums.Min();
                Console.WriteLine(minNum);
            }


        }
    }
}
