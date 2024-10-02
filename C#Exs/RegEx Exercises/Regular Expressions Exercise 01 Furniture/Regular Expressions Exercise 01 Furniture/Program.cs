using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Exercise_01_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<Item>\w+)<<(?<Cost>[\d.]+)!(?<Quantity>[\d]+)";

            string input = string.Empty;

            List<Match> prods = new List<Match>();

            while (input != "Purchase")
            {
                input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    prods.Add(Regex.Match(input, pattern));
                }
            }

            double sum = 0;
            Console.WriteLine("Bought furniture:");
            
            foreach (var item in prods)
            {
                double cost = double.Parse(item.Groups["Cost"].Value);
                double quantity = double.Parse(item.Groups["Quantity"].Value);
                sum += cost * quantity;
                Console.WriteLine(item.Groups["Item"].Value);
            }
            
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
