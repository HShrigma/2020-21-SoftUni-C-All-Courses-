using System;

namespace ANDPR
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderNum = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine()) * 8;
            
            double actualNum = (workers * workHours) / 3;
            double actualNum32 = Math.Floor(actualNum);
            double diff, profitOrLoss;

            if (actualNum32 >= orderNum)
            {
                diff = actualNum32 - orderNum;
                profitOrLoss = diff * 110.10;
                Console.WriteLine($"Profit: -> {profitOrLoss:F2} BGN");
            }
            else
            {
                diff = orderNum - actualNum32;
                profitOrLoss = diff * 110.10;
                Console.WriteLine($"Losses: -> {profitOrLoss:F2} BGN");
            }

        }
    }
}
