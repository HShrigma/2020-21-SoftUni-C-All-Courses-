using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            this.AllowedFoods = new List<string>() { "Fruit", "Vegetable", "Meat", "Seeds" };
            this.HungryHowl = "Cluck";
            this.WeightIncrease = 0.35;
        }
    }
}
