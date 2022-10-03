using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> add = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]++;
                }
            
            };

            Action<List<int>> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]*=2;
                }

            };

            Action<List<int>> substract = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }

            };

            Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));


            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end")
                {
                    break;
                }

                switch (command)
                {

                    case "add":
                        add(numbers);
                        break;

                    case "substract":
                        substract(numbers);
                        break;

                    case "multiply":
                        multiply(numbers);
                        break;

                    case "print":
                        print(numbers);
                        break;
                    
                }
            }
        }
    }
}
