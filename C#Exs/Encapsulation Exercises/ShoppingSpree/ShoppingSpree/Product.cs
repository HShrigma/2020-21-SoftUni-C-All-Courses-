using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
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
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Cost cannot be negative");
                cost = value;
            }
        }
        private bool NameIsEmpty(string name)
        {
            return name == string.Empty || name == null || name == " ";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
