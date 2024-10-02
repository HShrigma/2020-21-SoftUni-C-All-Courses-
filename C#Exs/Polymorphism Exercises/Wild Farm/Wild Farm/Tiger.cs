using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            this.AllowedFoods = new List<string>() { "Meat" };
            this.HungryHowl = "ROAR!!!";
            this.WeightIncrease = 1.00;
        }
    }
}
