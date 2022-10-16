﻿using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                continents[continent].Add(country,new List<string> {});

                }
                continents[continent][country].Add(city);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var item in continent.Value)
                {
                    Console.Write($"{item.Key} -> ");
                    Console.Write(string.Join(", ", item.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
