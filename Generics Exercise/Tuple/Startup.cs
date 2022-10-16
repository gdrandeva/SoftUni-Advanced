using System;
using System.Linq;

namespace Tuple
{
    public class Startup
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] drinkTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] numbersTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            Tuple<string, string> nameAddress = new Tuple<string, string>
            {
                Item1 = $"{personTokens[0]} {personTokens[1]}",
                Item2 = $"{personTokens[2]}"
            };

            Tuple<string, int> nameBeer = new Tuple<string, int>
            { 
            Item1 = $"{drinkTokens[0]}",
            Item2 = int.Parse(drinkTokens[1])
            };

            Tuple<int, double> numbers = new Tuple<int, double>
            {
                Item1 = numbersTokens[1],
                Item2 = numbersTokens[1]
            };

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(numbers);
        }
    }
}
