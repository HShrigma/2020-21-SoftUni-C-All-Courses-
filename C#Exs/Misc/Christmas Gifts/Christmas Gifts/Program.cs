using System;

namespace Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int toyPrice = 5;
            int sweaterPrice = 15;
            int toyCount = 0;
            int sweaterCount = 0;
            int adultsNum = 0;
            int kidsNum = 0;
            while (input != "Christmas")
            {
                input = Console.ReadLine();
                if (input == "Christmas")
                {
                    break;
                }
                int age = int.Parse(input);
                if (age <= 16)
                {
                    toyCount++;
                    kidsNum++;
                }
                else
                {
                    sweaterCount++;
                    adultsNum++;
                }
            }
            Console.WriteLine($"Number of adults: {adultsNum}");
            Console.WriteLine($"Number of kids: {kidsNum}");
            Console.WriteLine($"Money for toys: {toyCount * toyPrice}");
            Console.WriteLine($"Money for sweaters: {sweaterCount * sweaterPrice}");
        }
    }
}
