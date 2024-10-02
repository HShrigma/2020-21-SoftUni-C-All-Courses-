/*Write a program that receives an integer N on first line. 
 * On the next N lines, read pairs of "[name], [age]". Then read three lines with:
 * Condition - "younger" or "older"
 * Age - Integer
 * Format - "name", "age" or "name age"
 * 
 * Depending on the condition, print the correct pairs in the correct format. 
 * Don’t use the built-in functionality from .NET. Create your own methods.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_5_Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> nameAgePairs = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console
                    .ReadLine()
                    .Split(", ");

                nameAgePairs.Add(input[0], int.Parse(input[1]));
            }
            //condition being younger or older
            string condition = Console.ReadLine();
            //age being condition age
            int age = int.Parse(Console.ReadLine());
            //print format being:
            //1. name - $"{name}" 
            //2. age -  $"{age}"
            //3. name age - $"{name} - {age}"
            string format = Console.ReadLine();
            var filtered = nameAgePairs.Where(FilterAge(condition, age));

            foreach (var item in filtered)
                Console.WriteLine(FormatString(item,format));

        }

        public static Func<KeyValuePair<string, int>, bool> FilterAge(string olderOrYounger, int age)
        {
            if (olderOrYounger == "older")
            {
                return n => n.Value >= age;
            }
            else
            {
                return n => n.Value < age;
            }
        }

        public static string FormatString(KeyValuePair<string, int> pair, string format) 
        {
            switch (format)
            {
                case "name":
                    return pair.Key;
                case "age":
                    return pair.Value.ToString();
                default:
                    return $"{pair.Key} - {pair.Value}";
            }
        }
    }
}
