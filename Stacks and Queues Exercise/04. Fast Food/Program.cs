﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            

            Queue<int> ordersQueue = new Queue<int>(orders);

            Console.WriteLine(ordersQueue.Max());

            while (ordersQueue.Count > 0)
            {
                if (foodQuantity >= ordersQueue.Peek())
                {
                    foodQuantity -= ordersQueue.Dequeue();
                }
                else
                {
                break;
                }
            }

            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: " + String.Join(" ", ordersQueue));
                return;
            }

        }

    }
}
