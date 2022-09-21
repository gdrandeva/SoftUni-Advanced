using System;
using System.Collections.Generic;

namespace _7._Hot_potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int tosses = int.Parse(Console.ReadLine());
            Queue<string> queueOfChildren = new Queue<string>();
            int count = 1;

            foreach (var child in children)
            {
                queueOfChildren.Enqueue(child);
            }

            while (queueOfChildren.Count>1)
            {
                for (int i = 0; i < tosses-1; i++)
                {
                    queueOfChildren.Enqueue(queueOfChildren.Dequeue());
                }
                
                    Console.WriteLine($"Removed {queueOfChildren.Dequeue()}");
              
            }
            Console.WriteLine($"Last is {queueOfChildren.Dequeue()}");
            
            
        }
    }
}
