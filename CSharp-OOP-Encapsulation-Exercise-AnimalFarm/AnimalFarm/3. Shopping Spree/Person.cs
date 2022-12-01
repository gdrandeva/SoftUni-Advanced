using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Shopping_Spree
{
   public class Person
    {
        private string name;
        private int money;
        private List<Product> productsBag;

        public Person(string name, int money)
        {
            productsBag = new List<Product>();

            this.Name = name;
            this.Money = money;

        }

        public string  Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameCannotBeEmpty);
                }
                this.name = value;
            }
        }

        public int Money 
        {
            get
            {
                return this.money;
            }

            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.MoneyCannotBeNegative);
                }
                this.money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                productsBag.Add(product);
                this.Money -= product.Cost;
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }

        }
    }
}
