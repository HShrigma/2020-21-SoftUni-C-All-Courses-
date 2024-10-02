using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Objects_and_Classes_Lab_01_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int toFactorial = int.Parse(Console.ReadLine());

            BigInteger factorial = toFactorial;

            for (int i = toFactorial - 1 ; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
