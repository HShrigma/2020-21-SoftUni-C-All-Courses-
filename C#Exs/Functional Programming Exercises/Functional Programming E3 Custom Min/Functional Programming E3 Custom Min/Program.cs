/* using Func<T,T>, create function to print min without using .Min()
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_E3_Custom_Min
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Console.WriteLine(FindSmallest(nums));
        }

        static int FindSmallest(int[] input)
        {
            int output = int.MaxValue;
            Func<int, int, int> smaller = (x, y) => x < y ? x : y;

            foreach (var num in input)
                output = smaller(output, num);

            return output;
        }
    }
}
