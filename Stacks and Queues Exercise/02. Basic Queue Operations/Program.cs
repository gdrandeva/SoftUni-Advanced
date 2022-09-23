using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int queueAdd = numbers[0];
            int queueRemove = numbers[1];
            int queueFind = numbers[2];

            int[] givenArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < queueAdd; i++)
            {
                nums.Enqueue(givenArr[i]);
            }

            for (int i = 0; i < queueRemove; i++)
            {
                nums.Dequeue();
            }

            if (nums.Contains(queueFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (nums.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(nums.Min());
                }
            }
        }
    }
}
