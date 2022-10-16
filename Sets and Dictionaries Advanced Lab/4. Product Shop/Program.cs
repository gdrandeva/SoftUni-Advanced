﻿using System;
using System.Collections.Generic;

namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> foodByShops = new SortedDictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command!="Revision")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!foodByShops.ContainsKey(shop))
                {
                    foodByShops.Add(shop, new Dictionary<string, double>());
                }
                foodByShops[shop].Add(product, price);


                command = Console.ReadLine();
            }

            foreach (var shop in foodByShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
