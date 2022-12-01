using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> productsList = new List<Product>();

            string[] peopleInfo = Console.ReadLine().Split(";");
            string name = peopleInfo[0].Split("=").First();
            int money = int.Parse(peopleInfo[0].Split("=").Last());

            Person person = new Person(name, money);


            string[] productInfo = Console.ReadLine().Split(";");
            string productName = peopleInfo[0].Split("=").First();
            int productCost = int.Parse(peopleInfo[0].Split("=").Last());

            Product product = new Product(productName,productCost);


           string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person personName = cmdArgs[0];
                string purchasedProduct = cmdArgs[1];
               
                

                input = Console.ReadLine();
            }

        }
    }
}
