using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public virtual string Name { get; set; }
        public virtual double Weight { get; set; }

        public virtual int FoodEaten { get; set; }

        public virtual List<string> AllowedFoods {get;set;}
        public virtual void Eat(Food food)
        {
            Console.WriteLine(this.HungryHowl);

            if (AllowedFoods.Contains(food.GetType().Name))
            {
                this.Weight += (food.Quantity * this.WeightIncrease);

                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
        public virtual double WeightIncrease { get; set; }

        public virtual string HungryHowl { get; set; }

    }
}
