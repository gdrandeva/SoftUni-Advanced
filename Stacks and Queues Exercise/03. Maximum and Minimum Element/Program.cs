using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                switch (query[0])
                {
                    case 1:
                        int num = query[1];
                        stack.Push(num);
                        break;
                    case 2:
                        if (stack.Count!=0)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            continue;
                        }
                        
                        break;
                    case 3:
                        if (stack.Count==0)
                        {
                            continue;
                        }
                        Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(stack.Min());
                        break;
                   
                }
            }
            
                Console.Write(string.Join(", ", stack));
            
        }
    }
}
