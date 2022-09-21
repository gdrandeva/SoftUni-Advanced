using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queueOfNames = new Queue<string>();

            while (input != "Paid" && input != "End")
            {
                queueOfNames.Enqueue(input);
                input = Console.ReadLine();
            if (input=="Paid")
            {
                foreach (var name in queueOfNames)
                {
                    Console.WriteLine(name);
                }
                    while (queueOfNames.Count>0)
                    {
                        queueOfNames.Dequeue();
                    }
                   // queueOfNames.Clear();
                input = Console.ReadLine();
            }
            else if (input=="End")
            {
                Console.WriteLine($"{queueOfNames.Count} people remaining.");
                break;
            }
            }
        }
    }
}
