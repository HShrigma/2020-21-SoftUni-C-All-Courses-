using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {

        private const double coffeeMilliliters = 50;
        private const decimal CoffeePrice = (decimal)3.50;
        public Coffee(string name, double caffeine)
            :base(name, CoffeePrice, coffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine  { get; set; }
    }
}
