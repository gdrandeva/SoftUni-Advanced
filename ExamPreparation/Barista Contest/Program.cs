using System;
using System.Collections.Generic;
using System.Linq;

namespace Barista_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffee = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> milk = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<string, int> drinkRecipe = new Dictionary<string, int>
            {
                {"Cortado",50},
                {"Espresso",75 },
                {"Capuccino",100 },
                {"Americano",150 },
                {"Latte",200 }
            };
            Dictionary<string, int> madeDrink = new Dictionary<string, int>
            {
                {"Cortado",0},
                {"Espresso",0 },
                {"Capuccino",0 },
                {"Americano",0 },
                {"Latte",0 }
            };

            int coffeeQuantity = 0;
            int milkQuantity = 0;
            int sum = 0;

            while (coffee.Count !=0 && milk.Count!=0)
            {
                coffeeQuantity = coffee.Dequeue();
                milkQuantity = milk.Pop();
                sum = coffeeQuantity + milkQuantity;

                if (drinkRecipe.Values.Contains(sum))
                {
                    var drink = drinkRecipe.FirstOrDefault(d => d.Value == sum).Key;
                    madeDrink[drink]++;
                }
                else
                {
                    milk.Push(milkQuantity-5);
                }
            }
            if (coffee.Count==0 && milk.Count==0)
            {
            Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            if (coffee.Count>0)
            {
                Console.WriteLine("Coffee left: "+string.Join(", ", coffee));
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }

            if (milk.Count > 0)
            {
                Console.WriteLine("Milk left: " + string.Join(", ", milk));
            }
            else
            {
                Console.WriteLine("Milk left: none");
            }

            foreach (var drink in madeDrink.OrderBy(n=>n.Value).ThenByDescending(d=>d.Key))
            {
                if (drink.Value>0)
                {
                Console.WriteLine($"{drink.Key}: {drink.Value}");

                }
            }

        }
    }
}
