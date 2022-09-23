using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassCrossroad = int.Parse(Console.ReadLine());
            string command = Console.ReadLine(); 
            Queue<string> carsQueue = new Queue<string>();
            int carPassed = 0;

            while (command != "end")
            {
                if (command == "green")
                {

                    for (int i = 0; i < carsPassCrossroad; i++)
                    {
                        if (carsQueue.Count>0)
                        {

                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carPassed++;
                        }
                    }

                }
                else
                {
                    carsQueue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{carPassed} cars passed the crossroads.");
            return;


        }
    }
}
