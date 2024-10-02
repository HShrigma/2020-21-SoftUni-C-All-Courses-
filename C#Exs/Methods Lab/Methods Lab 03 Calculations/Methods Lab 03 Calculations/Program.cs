using System;

namespace Methods_Lab_03_Calculations
{
    class Program
    {
        static void BasicCalculations(string calcType)
        {
            int numOne = int.Parse(Console.ReadLine()); 
            int numTwo = int.Parse(Console.ReadLine());

            switch (calcType)
            {
                case "add":
              
                    Console.WriteLine(numOne + numTwo);
                    break;

                case "multiply":
                    Console.WriteLine(numOne * numTwo);
                    break;

                case "subtract":
                    Console.WriteLine(numOne - numTwo);
                    break;

                case "divide":
                    Console.WriteLine(numOne / numTwo);
                    break;

                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BasicCalculations(input);
        }
    }
}
