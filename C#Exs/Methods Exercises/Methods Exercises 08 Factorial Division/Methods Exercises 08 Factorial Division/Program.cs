using System;

namespace Methods_Exercises_08_Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long numOne = long.Parse(Console.ReadLine());
            
            long numTwo = long.Parse(Console.ReadLine());
           
            Console.WriteLine($"{DivideFactorials(numOne, numTwo):F2}");
        }

        static double DivideFactorials(long toFactorialDivided, long toFactorialDivider)
        {
            double factorialOne = FindFactorialForN(toFactorialDivided);
            double factorialTwo = FindFactorialForN(toFactorialDivider);
            
            double result = factorialOne / factorialTwo;
            
            return result;
        }
        static long FindFactorialForN(long n)
        {
            long factorial = n;
            if (n > 0)
            {
                factorial = 1;
                for (long i = n; i > 0; i--)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }
    }
}
