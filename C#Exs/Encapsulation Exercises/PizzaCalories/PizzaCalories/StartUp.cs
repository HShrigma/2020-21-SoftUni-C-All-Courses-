using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {

                //input will be like: "Pizza {pizzaName}"
                //so we will need to split by whitespace and take element at index 1
                string name = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                //input format for though: Dough {type} {technique} {weight}
                string[] doughStats = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Dough dough = new Dough(doughStats[1], doughStats[2], double.Parse(doughStats[3]));

                Pizza pizza = new Pizza(name, dough);
                string input = string.Empty;

                while ((input = Console.ReadLine()) != "END")
                {
                    //input format for toppings: Topping {Name} {weight}
                    string[] command = input
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    pizza.AddTopping(new Topping(command[1], double.Parse(command[2])));
                }
                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
