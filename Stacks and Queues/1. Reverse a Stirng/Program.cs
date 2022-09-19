using System;
using System.Collections.Generic;

namespace _1._Reverse_a_Stirng
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversedStr = new Stack<char>();

            foreach (var item in input)
            {
                reversedStr.Push(item);
            }

            while (reversedStr.Count > 0)
            {
                Console.Write(reversedStr.Pop());

            }
        }
    }
}
