using System;

namespace Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string stock = Console.ReadLine();
            int ammount = int.Parse(Console.ReadLine());
            double price = 0;
            double endPrice = 0;
            switch (team)
            {
                case "Argentina":
                    switch (stock)
                    {
                        case "flags":
                            price = 3.25;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv."); 
                            break;
                        case "caps":
                            price = 7.20;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "posters":
                            price = 5.10;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "stickers":
                            price = 1.25;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        default:
                            Console.WriteLine("Invalid stock!"); 
                            break;
                    }
                    break;
                case "Brazil":
                    switch (stock)
                    {
                        case "flags":
                            price = 4.20;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "caps":
                            price = 8.50;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "posters":
                            price = 5.35;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "stickers":
                            price = 1.20;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Croatia":
                    switch (stock)
                    {
                        case "flags":
                            price = 2.75;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "caps":
                            price = 6.90;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "posters":
                            price = 4.95;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "stickers":
                            price = 1.10;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Denmark":
                    switch (stock)
                    {
                        case "flags":
                            price = 3.10;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "caps":
                            price = 6.50;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "posters":
                            price = 4.80;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        case "stickers":
                            price = 0.90;
                            endPrice = price * ammount;
                            Console.WriteLine($"Pepi bought {ammount} {stock} of {team} for {endPrice:F2} lv.");
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    break;
            }
        }
    }
}
