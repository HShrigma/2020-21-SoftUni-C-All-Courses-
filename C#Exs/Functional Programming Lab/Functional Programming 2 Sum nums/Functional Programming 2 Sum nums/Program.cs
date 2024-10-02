/* read nums like:  x, y, z, ... n
 * create my own int.parse func.
 * print numscount,
 * print sum.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_2_Sum_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);

            List<int> nums = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToList();
            Console.WriteLine(nums.Count+"\n"+nums.Sum());
        }
    }
}
