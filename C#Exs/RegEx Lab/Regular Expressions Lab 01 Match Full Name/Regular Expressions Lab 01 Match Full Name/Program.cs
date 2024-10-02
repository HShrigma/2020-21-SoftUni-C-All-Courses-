using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Lab_01_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternRegex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

            string toMatch = Console.ReadLine();

            MatchCollection matches = Regex.Matches(toMatch, patternRegex);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
