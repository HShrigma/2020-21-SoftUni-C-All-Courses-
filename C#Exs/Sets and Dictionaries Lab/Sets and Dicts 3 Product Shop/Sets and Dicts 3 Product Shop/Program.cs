/* Write a program that prints information about food shops in Sofia 
 * and the products they store. Until the "Revision" command is received, 
 * you will be receiving input in the format: "{shop}, {product}, {price}".  
 * Keep in mind that if you receive a shop you already have received, 
 * you must collect its product information.
 * Your output must be ordered by shop name and must be in the format:
 * "{shop}->
 * Product: {product}, Price: {price}"
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_3_Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //create empty Multi-Dictionary of type
            //Key - String,
            //Value = Dictionary<string,double>

            Dictionary<string, Dictionary<string, double>> 
                shops 
                = 
                new Dictionary<string, Dictionary<string, double>>();

            //set end bool for input

            bool end = false;

            while (!end)
            {
                string[] command = ReadStringArray();

                switch (command[0])
                {
                    case "Revision":
                        end = true;
                        break;
                    default:
                        if (!shops.ContainsKey(command[0]))
                        {
                            shops.Add(command[0], new Dictionary<string, double>());
                        }
                        shops[command[0]].Add(command[1],double.Parse(command[2]));
                        break;
                }
            }
            //print result
            foreach (var shop in shops.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }

        static string[] ReadStringArray()
        {
            return Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
