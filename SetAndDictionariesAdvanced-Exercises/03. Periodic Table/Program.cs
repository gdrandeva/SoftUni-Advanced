using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> periodicElements = new HashSet<string>();

            //int count = int.Parse(Console.ReadLine());


            //for (int i = 0; i < count; i++)
            //{
            //    string[] compounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    periodicElements.UnionWith(compounds);
            //}

            //Console.WriteLine(string.Join(" ", periodicElements.OrderBy(p => p)));


            SortedSet<string> periodicElements = new SortedSet<string>();

            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                string[] compounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                periodicElements.UnionWith(compounds);
            }

            Console.WriteLine(string.Join(" ", periodicElements));

        }
    }
}
