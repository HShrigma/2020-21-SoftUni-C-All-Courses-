/* Get a sequence of numbers, and print only the even ones sorted by ascending order.
 * Use only 2 Lambda expressions
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_1_Sort_Even_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
