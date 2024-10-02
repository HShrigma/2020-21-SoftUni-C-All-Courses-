using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double caloriesPerGram = 2;
        private double modifier;
        private double grams;
        public Topping(string type, double grams)
        {
            type = type.ToLower();
            type = char.ToUpper(type[0]) + type.Substring(1, type.Length - 1);

            this.Type = type;
            switch (this.Type)
            {
                case "Meat":
                    this.modifier = 1.2;
                    break;
                case "Veggies":
                    this.modifier = 0.8;
                    break;
                case "Cheese":
                    this.modifier = 1.1;
                    break;
                case "Sauce":
                    this.modifier = 0.9;
                    break;
            }

            this.Grams = grams;
            this.caloriesPerGram *= modifier;
        }

        public double Calories
        {
            get
            {
                return this.grams * this.caloriesPerGram;
            }
        }
        private string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                this.type = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            set
            {
                if (value < 1 || value > 50)
                    throw new Exception($"{this.Type} weight should be in the range [1..50].");
                this.grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return this.caloriesPerGram;
            }
        }
    }
}
