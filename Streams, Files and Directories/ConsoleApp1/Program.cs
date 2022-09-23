using System;
using System.IO;

namespace ConsoleApp1
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../ScoreBoard.txt"))
            {
                string scoreboard = reader.ReadToEnd();
                Console.WriteLine(scoreboard);
            }
        }
    }
}
