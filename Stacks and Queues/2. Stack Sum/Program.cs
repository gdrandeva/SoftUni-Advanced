using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
            int sum = 0;

            while (command!= "end")
            {
                string[] commandAndAction = command.Split();

                switch (commandAndAction[0])
                {
                    case "add":
                        int firstNum = int.Parse(commandAndAction[1]);
                        int secondNum = int.Parse(commandAndAction[2]);
                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int countToRemove = int.Parse(commandAndAction[1]);
                        if (countToRemove>stack.Count)
                        {
                            command = Console.ReadLine().ToLower();
                            continue;
                        }
                        else
                        {
                            for (int i = 1; i <= countToRemove; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;

                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
