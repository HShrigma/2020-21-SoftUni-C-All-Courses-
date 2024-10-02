/* Write a program that prints a number from a collection, 
 * which appears an even number of times in it. 
 * On the first line, you will be given n – the count of integers you will receive. 
 * On the next n lines you will be receiving the numbers. 
 * It is guaranteed that only one of them appears an even number of times. 
 * Your task is to find that number and print it in the end.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_E4_Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            //get N
            int n = int.Parse(Console.ReadLine());
            //create empty dictionary
            Dictionary<int, int> nums = new Dictionary<int, int>();
            //fill it in N times

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!nums.ContainsKey(input))
                    nums.Add(input, 0);

                nums[input]++;
            }

            //find number with even value
            int res = default;

            foreach (var item in nums)
            {
                if (item.Value % 2 == 0)
                {
                    res = item.Key;
                    break;
                }
            }

            //print result
            Console.WriteLine(res);
        }
    }
}
