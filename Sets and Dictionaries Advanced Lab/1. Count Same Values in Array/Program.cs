using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int count = 1;
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i],0);
                }
                else
                {
                    numbersCount[numbers[i]]++;
                }
            }

            foreach (var key in numbersCount.Keys)
            {
                var value = numbersCount[key];
                    Console.WriteLine($"{key} - {value} times");
                
            }
        }
    }
}
