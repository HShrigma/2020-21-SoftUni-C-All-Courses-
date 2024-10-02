using System;

namespace Cat_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catNum = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double foodPriceperGram = 12.45 / 1000;
            double gramCount = 0;
            for (int i = 1; i <= catNum; i++)
            {
                double foodGrams = double.Parse(Console.ReadLine());
                if (foodGrams >= 100 && foodGrams < 200)
                {
                    group1++;
                }
                else if (foodGrams >= 200 && foodGrams < 300)
                {
                    group2++;
                }
                else if (foodGrams >= 300 && foodGrams < 400)
                {
                    group3++;
                }
                gramCount+= foodGrams;
            }
            double totalSum = gramCount * foodPriceperGram;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {totalSum:F2} lv.");
        }
    }
}
