using System;

namespace _2._Enter_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int start = 0;
                int end = 0;
                ReadNumber(start, end);
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void ReadNumber(int start, int end)
        {
            start = 1;
            end = 100;

            int n = int.Parse(Console.ReadLine());
            while (n > 1 && n < 100)
            {
                for (int i = 0; i < 10; i++)
                {

                    n = int.Parse(Console.ReadLine());
                }
            }

            if (n == start || n == end)
            {
                throw new ArgumentException($"Your number is not in range {n} - 100!");
            }
            else if (!Char.IsDigit((char)n))
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }
    }
}
