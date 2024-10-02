/* Write a program, which will take a list of names 
 * and print only the unique names in the list.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_5Unique_names
{
    class Program
    {
        static void Main(string[] args)
        {
            //get loop count N
            int n = int.Parse(Console.ReadLine());

            //create empty hash set
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
