using System;
using System.Globalization;

class Program
{   
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string command = string.Empty;
        double outFall4Price = 39.99;
        double cSOGPrice = 15.99;
        double zplinterZellPrice = 19.99;
        double honored2Price = 59.99;
        double roverWatchPrice = 29.99;
        double originsPrice = 39.99;
        double spent = 0.00;

        while (command != "Game Time")
        {
            if (budget <= 0.00)
            {
                break;            
            }
            command = Console.ReadLine();
            if (command == "Game Time")
            {
                break;
            }
            else if (command == "OutFall 4")
            {
                if (budget >= outFall4Price)
                {
                    budget -= outFall4Price;
                    spent += outFall4Price;
                    Console.WriteLine("Bought OutFall 4");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (command == "CS: OG")
            {
                if (budget >= cSOGPrice)
                {
                    budget -= cSOGPrice;
                    spent += cSOGPrice;
                    Console.WriteLine("Bought CS: OG");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (command == "Zplinter Zell")
            {
                if (budget >= zplinterZellPrice)
                {
                    budget -= zplinterZellPrice;
                    spent += zplinterZellPrice;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (command == "Honored 2")
            {
                if (budget >= honored2Price)
                {
                    budget -= honored2Price;
                    spent += honored2Price;
                    Console.WriteLine("Bought Honored 2");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (command == "RoverWatch")
            {
                if (budget >= roverWatchPrice)
                {
                    budget -= roverWatchPrice;
                    spent += roverWatchPrice;
                    Console.WriteLine("Bought RoverWatch");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (command == "RoverWatch Origins Edition")
            {
                if (budget >= originsPrice)
                {
                    budget -= originsPrice;
                    spent += originsPrice;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
       
        if (budget > 0)
        {
            Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${budget:F2}");
        }
        else
        {
            Console.WriteLine("Out of money!");
        }
    }
}