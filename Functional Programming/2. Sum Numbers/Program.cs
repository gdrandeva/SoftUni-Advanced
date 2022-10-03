﻿using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);

            int[] input = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(parser)
               .ToArray();

            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());


            
        }
    }
}
