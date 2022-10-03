using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsSeq = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            Queue<string> songs = new Queue<string>(songsSeq);
           // Stack<string> songs = new Stack<string>(songsSeq);
            while (songs.Count!=0)
            {
                string[] command = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", command.Skip(1));
                        if (!songs.Contains(song))
                        {
                            songs.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songs));
                        break;

                    
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
