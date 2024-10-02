using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Lab_03_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";

            MatchCollection dates = Regex
                .Matches(Console.ReadLine(), regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"];

                var month = date.Groups["month"];

                var year = date.Groups["year"];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
