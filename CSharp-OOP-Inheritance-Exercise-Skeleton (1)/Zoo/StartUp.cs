using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var bear = new Bear("Masha");
            Console.WriteLine(bear);
            var snake = new Snake("Sneji");
            Console.WriteLine(snake);
            var gorilla = new Gorilla("bocko");
            Console.WriteLine(gorilla);
            var lizard = new Lizard("Igu");
            Console.WriteLine(lizard);
        }
    }
}