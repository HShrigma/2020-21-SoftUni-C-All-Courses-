using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dish - Freshness needed:
             * Dipping Sauce - 150;
             * Green Salad - 250;
             * Chocolate Cake - 300
             * Lobster - 400
             */
            //log dishes
            Dictionary<string, Dish> dishes = new Dictionary<string, Dish>();
            dishes.Add("Dipping sauce", new Dish(150));
            dishes.Add("Green salad", new Dish(250));
            dishes.Add("Chocolate cake", new Dish(300));
            dishes.Add("Lobster", new Dish(400));


            List<int> ingridients = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> freshness = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (ingridients.Any() && freshness.Any())
            {
                int combined = ingridients.First() * freshness.Last();

                bool cooked = false;

                foreach (var item in dishes)
                {
                    if (combined == item.Value.NeededFreshness)
                    {
                        item.Value.Made++;
                        cooked = true;
                        break;
                    }
                }

                if (cooked)
                {
                    ingridients.RemoveAt(0);
                    freshness.RemoveAt(freshness.Count - 1);
                }
                else
                {
                    if (ingridients.First() != 0)
                    {
                        int temp = ingridients.First() + 5;
                        freshness.RemoveAt(freshness.Count - 1);
                        ingridients.RemoveAt(0);
                        ingridients.Add(temp);
                    }
                    else
                    {
                        ingridients.RemoveAt(0);
                    }
                }
            }

            bool impressed = true;

            foreach (var item in dishes)
            {
                if (item.Value.Made == 0)
                {
                    impressed = false;
                    break;
                }
            }

            if (impressed)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingridients.Any())
                Console.WriteLine($"Ingredients left: {ingridients.Sum()}");
            if (dishes.Where(n => n.Value.Made > 0).Any())
            {
                foreach (var item in dishes.Where(n => n.Value.Made > 0).OrderBy(n => n.Key))
                {
                    Console.WriteLine($" # {item.Key} --> {item.Value.Made}");
                }
            }

        }
    }

    class Dish
    {
        public int NeededFreshness { get; set; }
        public int Made { get; set; }

        public Dish(int freshness)
        {
            NeededFreshness = freshness;
            Made = 0;
        }
    }
}
