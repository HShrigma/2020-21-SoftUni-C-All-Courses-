using System;

namespace FloatCompar
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (numOne>numTwo)
            {
                if (numOne - numTwo < eps)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (numTwo>numOne)
            {
                if (numTwo - numOne < eps)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
