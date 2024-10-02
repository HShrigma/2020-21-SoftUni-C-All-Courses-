using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Fund_Mid_Exam_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double total = 0;
            
            for (int i = 0; i < orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                
                int daysInMonth = int.Parse(Console.ReadLine());

                int capsulesCount = int.Parse(Console.ReadLine()); //(daysInMonth * capsulesCount) * capsulePrice

                double priceForCoffee = (daysInMonth * capsulesCount) * capsulePrice;

                total += priceForCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceForCoffee:F2}");
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
