using System;

namespace Methods_Lab_08_Math_Power
{
    class Program
    {
        static double MathPower(double number, int toThePowerOf)
        {
            return Math.Pow(number, toThePowerOf);
        }
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            
            int numTwo = int.Parse(Console.ReadLine());

            double result = MathPower(numOne, numTwo);

            Console.WriteLine(result);
        }
    }
}
