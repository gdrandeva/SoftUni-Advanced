using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            Stack<int> stack = new Stack<int>();

            int firstNum = 0;
            int secondNum = 0;
            int sum = 0;

            foreach (var item in num)
            {
                stack.Push(int.Parse(item));
            }

            while (stack.Count>0)
            {
                sum += stack.Pop();
                if (stack.Pop().ToString() =="+")
                {
                    stack.Push(sum);
                }
                else if (stack.Pop().ToString() == "-")
                {
                    sum -=stack.Peek();

                }
                sum += stack.Pop();
            }

           
        }
    }
}
