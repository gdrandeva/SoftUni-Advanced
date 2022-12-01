using System;
using System.Collections.Generic;

namespace CustomRandomList
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Oscar");
            list.Add("Hana");
            list.Add("Nikolay");

            Console.WriteLine(list.RandomString());
        }
    }
}
