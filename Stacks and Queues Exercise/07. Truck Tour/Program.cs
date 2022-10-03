using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < petrolPumps; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }
            int leftFuel = 0;
            for (int j = 0; j < petrolPumps; j++)
            {
                int petrolAmountInLiters = int.Parse(pumps.Peek().Split().First());
                int distanceToNextStation = int.Parse(pumps.Peek().Split().Last());
                leftFuel += petrolPumps - distanceToNextStation;

                if (leftFuel>0)
                {
                    Console.WriteLine(j+1);
                }
                else
                {

                }
                    
            }
        }
    }
}
