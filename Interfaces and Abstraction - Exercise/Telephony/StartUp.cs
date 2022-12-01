using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] webSites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in numbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        
                    }
                }
                catch (InvalidNumberMessage inm)
                {

                    throw;
                }
            }
        }
    }
}
