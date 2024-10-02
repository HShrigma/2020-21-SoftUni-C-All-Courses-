using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> productBag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.productBag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (NameIsEmpty(value))
                    throw new Exception("Name cannot be empty");

                name = value;
            }
        }
        
        public double Money
        {
            get 
            {
                return money;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Money cannot be negative");

                money = value;
            }
        }

        public void Buy(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.productBag.Add(product);
                this.Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }

        public override string ToString()
        {
            if (this.productBag.Count > 0)
                return $"{this.Name} - {string.Join(", ", this.productBag)}";
            else
                return $"{this.Name} - Nothing bought";
        }
        private bool NameIsEmpty(string name)
        {
            return name == string.Empty || name == null || name == " ";
        }
    }
}
