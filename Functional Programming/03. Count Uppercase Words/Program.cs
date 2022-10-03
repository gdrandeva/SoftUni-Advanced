using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithCapital = w => char.IsUpper(w[0]);

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => startsWithCapital(x))
                .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }
    }
}
