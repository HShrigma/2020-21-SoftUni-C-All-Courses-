/* Write a program that reads some text from the console 
 * and counts the occurrences of each character in it. 
 * Print the results in alphabetical (lexicographical) order. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_E5_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            //get string
            string input = Console.ReadLine();

            //create empty dictionary
            Dictionary<char, int> symbolCount = new Dictionary<char, int>();
            
            //fill it in with each unique char and track reps

            foreach (var character in input)
            {
                if (!symbolCount.ContainsKey(character))
                    symbolCount.Add(character, 0);
                symbolCount[character]++;
            }

            //print it ordered ascendingly
            foreach (var item in symbolCount.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
