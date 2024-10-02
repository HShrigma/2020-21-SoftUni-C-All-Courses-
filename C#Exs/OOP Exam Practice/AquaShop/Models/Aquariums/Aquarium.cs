using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        protected string _name;

        protected Aquarium()
        {
            this.Fish = new List<IFish>();
            this.Decorations = new List<IDecoration>();
        }
        protected Aquarium(string name)
            : this()
        {
            this.Name = name;
        }
        protected Aquarium(string name, int capacity)
            : this(name)
        {
            this.Capacity = capacity;
        }

        public string Name
        {
            get { return this._name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                this._name = value;
            }
        }
        public int Capacity
        {
            get; 
        }

        public int Comfort => this.Decorations.Sum(x => x.Comfort);

        public ICollection<IDecoration> Decorations
        {
            get;
        }

        public ICollection<IFish> Fish
        {
            get;
        }

        public void AddDecoration(IDecoration decoration)
        {
            this.Decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (this.Fish.Count < this.Capacity)
            {
                this.Fish.Add(fish);
            }
            else
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
        }

        public void Feed()
        {
            foreach (var fish in this.Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            string fishInfo = this.Fish.Any() ? string.Join(", ", this.Fish.Select(n => n.Name)) : "none";

            return $"{this.Name} ({this.GetType().Name}):\nFish: {fishInfo}\nDecorations: {this.Decorations.Count}\nComfort: {this.Comfort}";
        }

        public bool RemoveFish(IFish fish)
        {
            if (this.Fish.Where(n => n.Name == fish.Name).Any())
            {
                int count = this.Fish.Count;
                this.Fish.Remove(this.Fish.FirstOrDefault(n => n.Name == fish.Name));

                return true;
            }
            return false;
        }
    }
}
