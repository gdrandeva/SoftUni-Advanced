using System;

namespace _1._Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine(FindSquareRoot(n));
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        static double FindSquareRoot(double n)
        {
            if (n<0)
            {
                throw new ArgumentException("Invalid number.");
            }
            return Math.Sqrt(n);
        }
    }
}
