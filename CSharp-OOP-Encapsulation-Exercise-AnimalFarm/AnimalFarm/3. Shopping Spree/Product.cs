using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Shopping_Spree
{
    public class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
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

        public int Cost
        {
            get
            {
                return this.cost;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.MoneyCannotBeNegative);
                }
                this.cost = value;
            }
        }

    }
}
