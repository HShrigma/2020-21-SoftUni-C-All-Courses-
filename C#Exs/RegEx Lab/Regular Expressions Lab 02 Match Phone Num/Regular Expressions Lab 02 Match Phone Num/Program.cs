using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Lab_02_Match_Phone_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"((\+359)([ -])[2](\3)\d{3}(\3)\d{4})\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            var allMatches = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", allMatches));
        }
    }
}
