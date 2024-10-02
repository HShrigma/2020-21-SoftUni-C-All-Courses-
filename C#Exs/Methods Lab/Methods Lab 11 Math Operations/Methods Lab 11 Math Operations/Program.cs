using System;

namespace Methods_Lab_11_Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());

            char operation = char.Parse(Console.ReadLine());

            int numTwo = int.Parse(Console.ReadLine());

            double res = Operations(numOne, operation, numTwo);
            
            if (res == (long)res)
            {
                Console.WriteLine($"{(long)res}");
            }
            
            else
            {
                Console.WriteLine($"{res:F2}");
            }

        }

        static double Operations(int x, char op, int y)
        {
            double result = 0;
            switch (op)
            {
                case '+': 
                    result = Addition(x, y);
                    break;
                case '-':
                    result = Subtraction(x, y);
                    break;
                case '*':
                    result = Multiplication(x, y);
                    break;
                case '/':
                    result = Division(x, y);
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
            return result;
        }
        static double Addition(double x, double y)
        {
            return x + y;
        }
        static double Subtraction(double toSubtract, double subtractor)
        {
            return toSubtract / subtractor;
        }
        static double Multiplication(double toMultiply, double multiplier)
        {
            return toMultiply * multiplier;
        }
        static double Division(double toDivide, double divider)
        {
            return toDivide / divider;
        }
    }
}
