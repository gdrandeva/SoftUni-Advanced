using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                { "Sink", 40 },
                { "Oven", 50 },
                { "Countertop", 60 },
                { "Wall", 70 },
                
            };

            Dictionary<string, int> possibleLocations = new Dictionary<string, int>()
            {
                { "Sink", 0 },
                { "Oven", 0 },
                { "Countertop", 0 },
                { "Wall", 0 },
                { "Floor", 0 },

            };

            while (whiteTiles.Count!=0 && greyTiles.Count!=0)
            {
                int white = whiteTiles.Pop();
                int grey = greyTiles.Dequeue();

                if (white==grey)
                {
                int newTile = white + grey;

                  //KeyValuePair<string,int>
                  var possibleLocation = locations.FirstOrDefault(x => x.Value == newTile);

                    if (possibleLocation.Key != null)
                    {
                        possibleLocations[possibleLocation.Key]++;
                    }
                    else
                    {
                        possibleLocations["Floor"]++;
                    }
                }
                else
                {
                    whiteTiles.Push(white/2);
                    greyTiles.Enqueue(grey);
                }

            }

            string whitesLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ",whiteTiles);
            string greysLeft = greyTiles.Count == 0 ? "none" : string.Join(", ",greyTiles);

            Console.WriteLine($"White tiles left: {whitesLeft}");
            Console.WriteLine($"Grey tiles left: {greysLeft}");


            possibleLocations = possibleLocations.Where(l => l.Value>0).OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(l => l.Key, l => l.Value);

            foreach (var location in locations)
            {
                //if (location.Value!=0)
                //{
                    Console.WriteLine($"{location.Key}: {location.Value}");
                //}
            }
        }
    }
}
