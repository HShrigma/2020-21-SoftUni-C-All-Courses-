using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        protected string _name;
        protected string _species;
        protected int _size;
        protected decimal _price;

        protected Fish()
        {

        }
        protected Fish(string name, string species, decimal price)
            : this()
        {
            this.Name = name;
            this.Species = species;
            this.Price = price;
        }

        public string Name
        {
            get { return this._name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Fish name cannot be null or empty.");
                }
                this._name = value;
            }
        }

        public string Species
        {
            get { return this._species; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Fish species cannot be null or empty.");
                }
                this._species = value;
            }
        }

        public int Size
        {
            get { return this._size; }
            protected set { this._size = value; }
        }

        public decimal Price
        {
            get { return this._price; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fish price cannot be below or equal to 0.");
                }
                this._price = value;
            }
        }
        public abstract void Eat();
    }
}
