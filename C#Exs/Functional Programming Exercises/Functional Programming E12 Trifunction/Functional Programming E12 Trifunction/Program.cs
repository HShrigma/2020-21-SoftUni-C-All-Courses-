/*Write a program that traverses a collection of names and returns the first name, 
 * whose sum of characters is equal to or larger than a given number N, which will be given on the first line. 
 * Use a function that accepts another function as one of its parameters. 
 * Start off by building a regular function to hold the basic logic of the program. 
 * Something along the lines of Func<string, int, bool>. 
 * Afterwards create your main function which should accept the first function as one of its parameters.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functional_Programming_E12_Trifunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] read = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<string, int> toAscii = str => str.ToList().Sum(n => (int)n);
            Func<string, bool> compareStr = word => toAscii(word) >= num;

            Console.WriteLine(read.First(n => compareStr(n)));
           
            
        }
    }
}
