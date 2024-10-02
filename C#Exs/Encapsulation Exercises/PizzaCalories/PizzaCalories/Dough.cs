using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaCalories
{
    public class Dough
    {
        private string flour;
        private string technique;
        private double grams;
        private double calories;
        private double modifier1;
        private double modifier2;
        private  double caloriesPerGram = 2;
        public Dough(string flour, string technique, double grams)
        {
            flour = flour.ToLower();
            flour = char.ToUpper(flour[0]) + flour.Substring(1, flour.Length - 1);

            technique = technique.ToLower();
            technique = char.ToUpper(technique[0]) + technique.Substring(1, technique.Length - 1);

            this.Flour = flour;
            this.Technique = technique;
            this.Grams = grams;

            switch(this.Flour)
            {
                case "White":
                    this.modifier1 = 1.5;
                    break;
                case "Wholegrain":
                    this.modifier1 = 1.0;
                    break;
            }
            switch(this.Technique)
            {
                case "Crispy":
                    this.modifier2 = 0.9;
                    break;
                case "Chewy":
                    this.modifier2 = 1.1;
                    break;
                case "Homemade":
                    this.modifier2 = 1.0;
                    break;
            }

            this.caloriesPerGram *= this.modifier1 * this.modifier2;
            
            this.calories = this.caloriesPerGram * this.grams;
        }

        public double Calories
        {
            get
            {
                return this.calories;
            }
        }
        private string Flour
        {
            get
            {
                return this.flour;
            }
            set
            {
                switch (value)
                {
                    case "White":
                    case "Wholegrain":
                        this.flour = value;
                        break;
                    default:
                        throw new Exception("Invalid type of dough.");
                }
            }
        } 

        private string Technique
        {
            get
            {
                return this.technique;
            }
            set
            {
                switch(value)
                {
                    case "Crispy":
                    case "Chewy":
                    case "Homemade":
                        this.technique = value;
                        break;
                    default:
                        throw new Exception("Invalid type of dough.");
                }
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
                if (value < 1 || value > 200)
                    throw new Exception("Dough weight should be in the range [1..200].");

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
