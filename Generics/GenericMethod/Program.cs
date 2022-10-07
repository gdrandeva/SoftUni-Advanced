using System;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(5);
            Print("Zdr");
        }

        public static void Print<T>(int input)
        {

            Console.WriteLine(typeof(T));
            Console.WriteLine(input);
        }
    }
}
