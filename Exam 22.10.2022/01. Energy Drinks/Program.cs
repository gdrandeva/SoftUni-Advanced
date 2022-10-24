using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Energy_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            const int INITIAL_CAFFEINE = 0;
          int maxCaffeine = 300;

            int totalCaffeine = 0;

            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> drinks = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int currentCaffeine =0;
            int currentDrink = 0;
            int drinkDose = 0;


            while (drinks.Count!=0 && caffeine.Count!=0)
            {
                currentCaffeine = caffeine.Pop();
                currentDrink = drinks.Dequeue();
                drinkDose = currentCaffeine * currentDrink;

                if (drinkDose + totalCaffeine <= maxCaffeine)
                {
                    totalCaffeine += drinkDose;
                   // maxCaffeine -= drinkDose;
                }
                else if (drinkDose + totalCaffeine > maxCaffeine)
                {
                    drinks.Enqueue(currentDrink);
                    totalCaffeine -= 30;
                    if (totalCaffeine<0)
                    {
                        totalCaffeine = 0;
                    }
                }
            }

            if (drinks.Count !=0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ",drinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");

            
        }



    }
}
