/* we get a single line array of doubles
 * we have to count each repetition of a value 
 * and list it like this(sorted by ocurrance in arr):
 * i1 - x times
 * ...
 * in - x times
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_1_count_same
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> repetitions = new Dictionary<double, int>();

            foreach (var item in input)
            {
                if (repetitions.ContainsKey(item))
                {
                    repetitions[item]++;
                }
                else
                {
                    repetitions.Add(item, 1);
                }
            }

            foreach (var item in repetitions)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
