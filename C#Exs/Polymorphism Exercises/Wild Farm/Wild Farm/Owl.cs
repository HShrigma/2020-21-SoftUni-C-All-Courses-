﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            this.AllowedFoods = new List<string>() {"Meat"};
            this.HungryHowl = "Hoot Hoot";
            this.WeightIncrease = 0.25;
        }
    }
}
