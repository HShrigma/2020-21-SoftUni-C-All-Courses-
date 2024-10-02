using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_E4_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            List<int> nums = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                nums.Add(i);
            }

            string evenOrOdd = Console.ReadLine();

            Console.WriteLine(string.Join(' ', nums.Where(n => EvenOrOddArray(evenOrOdd, n))));
        }

        static bool EvenOrOddArray(string evenOrOdd, int num)
        {
            Predicate<int> even = n => n % 2 == 0;
            Predicate<int> odd = n => n % 2 != 0;
            if (evenOrOdd == "even")
            {
                return even(num);
            }
            else
            {
                return odd(num);
            }
        }
    }
}
