/* Write a program that keeps all the unique chemical elements. 
 * On the first line you will be given a number n - the count of input lines 
 * that you are going to receive. On the next n lines you will be receiving 
 * chemical compounds, separated by a single space. 
 * Your task is to print all the unique ones in ascending order:
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_E3_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //get N
            int n = int.Parse(Console.ReadLine());
            
            //make empty sorted set
            SortedSet<string> chems = new SortedSet<string>();
            
            //fill it in N times
            for (int i = 0; i < n; i++)
            {
                string[] input = ReadStringArray();

                foreach (var element in input)
                {
                    chems.Add(element);
                }
            }

            //print result
            Console.WriteLine(string.Join(' ', chems));
        }

        static string[] ReadStringArray()
        {
            return Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
