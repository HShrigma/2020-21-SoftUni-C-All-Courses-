/* Write a program that reads a collection of strings from the console
 * and then prints them onto the console. 
 * Each name should be printed on a new line. 
 * Use Action<T>.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_E1_Action_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = n => Console.WriteLine(string.Join('\n',n));

            string[] names = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            print(names);
        }
    }
}
