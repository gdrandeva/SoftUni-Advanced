using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, string> addVAT = x => (x * 1.2M).ToString("F2");

            Console.Write(string.Join(Environment.NewLine, 
            Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(addVAT)));
        }
    }
}
