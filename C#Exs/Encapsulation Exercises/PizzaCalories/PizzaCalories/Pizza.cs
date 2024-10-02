using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == string.Empty || value.Length > 15)
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                this.name = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }

            set
            {
                if (value.Count > 10)
                    throw new Exception("Number of toppings should be in range [0..10].");
                toppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count >= 10)
                throw new Exception("Number of toppings should be in range [0..10].");
            this.Toppings.Add(topping);
        }

        public override string ToString()
        {
            double totalCalories = (this.dough.CaloriesPerGram * this.dough.Grams);
            this.Toppings.ForEach(n => totalCalories += n.Calories);
            

            return $"{this.Name} - {totalCalories:F2} Calories.";
        }
    }
}
