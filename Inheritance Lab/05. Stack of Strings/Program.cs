using System;
using System.Collections.Generic;

namespace CustomStack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(new List<string> { "1", "2", "3", "4"});
            stack.AddRange(new List<string> { "5", "6", "8", "9"});

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop()); 
            }
        }
    }
}
