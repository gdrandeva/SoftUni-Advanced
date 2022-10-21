using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));
            Stack<int> caloriesPerDay = new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<string, int> mealCalories = new Dictionary<string, int>
            {
                {"salad", 350},
                {"soup", 490 },
                {"pasta", 680},
                {"steak", 790}

            
            };
            
            int count = 0;
            
            
            while (meals.Count!=0 && caloriesPerDay.Count!=0)
            {
                string currentMeal = meals.Dequeue();
                int currentCalories = caloriesPerDay.Pop();

                if (mealCalories.ContainsKey(currentMeal))
                {
                    count++;
                    if (mealCalories[currentMeal] < currentCalories)
                    {
                        currentCalories -= mealCalories[currentMeal];
                        caloriesPerDay.Push(currentCalories);
                        
                        
                    }
                    else if (caloriesPerDay.Count !=0)
                    {
                       currentCalories = caloriesPerDay.Pop()+currentCalories - mealCalories[currentMeal];
                        caloriesPerDay.Push(currentCalories);
                        
                        
                    }
                }
  
            }
            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {count} meals.");
                Console.WriteLine($"For the next few days, he can eat {String.Join(", ", caloriesPerDay)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {count} meals.");
                Console.WriteLine($"Meals left: {String.Join(", ", meals)}.");
            }

        }
    }
}
