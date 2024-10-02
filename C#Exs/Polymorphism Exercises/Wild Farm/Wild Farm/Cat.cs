using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            this.AllowedFoods = new List<string>() { "Vegetable", "Meat" };
            this.HungryHowl = "Meow";
            this.WeightIncrease = 0.30;
        }
    }
}
