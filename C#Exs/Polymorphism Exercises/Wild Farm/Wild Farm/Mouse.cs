using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            this.AllowedFoods = new List<string>() {"Vegetable", "Fruit"};
            this.HungryHowl = "Squeak";
            this.WeightIncrease = 0.10;
        }
    }
}
