/* get a list of nums ex: 1.38, 2.56, 4.4
 * Add VAT (+20%)
 * Format to 2 signs after decimal point
 * print in input order
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_4_Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = n => double.Parse(n);
            Func<double, string> format = n => $"{n:F2}";
            Func<double, double> addVAT = n => n += (n / 5);
            
            List<string> nums =
                Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Select(addVAT)
                .Select(format)
                .ToList();

            Console.WriteLine(string.Join('\n', nums));
        }
    }
}
