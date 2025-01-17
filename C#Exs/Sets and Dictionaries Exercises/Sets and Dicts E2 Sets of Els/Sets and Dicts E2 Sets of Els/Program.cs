﻿/* Write a program that prints a set of elements. 
 * On the first line you will receive two numbers - n and m, 
 * which represent the lengths of two separate sets. On the next n + m lines you will receive n numbers, 
 * which are the numbers in the first set, and m numbers, which are in the second set. 
 * Find all the unique elements that appear in both of them and print them 
 * in the order in which they appear in the first set - n.
 * For example:
 * Set with length n = 4: {1, 3, 5, 7}
 * Set with length m = 3: {3, 4, 5}
 * Set that contains all the elements that repeat in both sets -> {3, 5}
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_E2_Sets_of_Els
{
    class Program
    {
        static void Main(string[] args)
        {
            //get set sizes
            int[] sizes = ReadIntArray();
            int n = sizes[0];
            int m = sizes[1];

            //create empty hash sets and init them in the following loops
            HashSet<int> first = new HashSet<int>();
            HashSet<int> last = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                last.Add(int.Parse(Console.ReadLine()));
            }
            
            //loop through first n to see which nums repeat themselves,
            //then feed them to print set

            HashSet<int> print = new HashSet<int>();

            foreach (var item in first)
            {
                if (last.Contains(item))
                {
                    print.Add(item);
                }
            }

            //print result
            Console.WriteLine(string.Join(' ', print));
        }

        static int[] ReadIntArray()
        {
            return Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
