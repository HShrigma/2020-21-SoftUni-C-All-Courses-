using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            this.AllowedFoods = new List<string>() {"Meat"};
            this.HungryHowl = "Woof!";
            this.WeightIncrease = 0.40 ;
        }
    }
}
