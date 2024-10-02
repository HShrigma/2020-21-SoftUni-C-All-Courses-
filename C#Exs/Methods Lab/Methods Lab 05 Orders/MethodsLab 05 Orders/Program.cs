using System;

namespace MethodsLab_05_Orders
{
    class Program
    {
        static void OrderCalc(string order, int size)
        {
            double price = 0;
            bool validOrder = true;
            switch (order)
            {
                case "coffee":
                    
                    price = 1.50;
                    
                    break;
                case "coke":
                    
                    price = 1.40;
                    
                    break;
                case "water":
                    
                    price = 1.00;
                    
                    break;
                case "snacks":
                    
                    price = 2.00;
                    
                    break;

                default:
                    
                    Console.WriteLine("Invalid order!");

                    validOrder = false;

                    break;
            }
            
            if (validOrder)
            {
                double result = price * size;

                Console.WriteLine($"{result:F2}");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int orderSize = int.Parse(Console.ReadLine());
            
            OrderCalc(input, orderSize);
        }
    }
}
