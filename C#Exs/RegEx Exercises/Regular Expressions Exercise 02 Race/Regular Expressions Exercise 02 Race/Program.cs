using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Exercise_02_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racerAndDistance = new Dictionary<string, int>();

            string[] participants = Console.ReadLine().Split(", ");

            foreach (var participant in participants)
            {
                racerAndDistance.Add(participant, 0);
            }

            string input = string.Empty;

            while (input != "end of race")
            {
                input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }
                
                string name = string.Join("", Regex.Matches(input, @"[A-Za-z]"));

                if (racerAndDistance.ContainsKey(name))
                {
                    MatchCollection numsRegex = Regex.Matches(input, @"\d");

                    foreach (Match num in numsRegex)
                    {
                        foreach (var item in num.Value)
                        {
                            if (char.IsDigit(item))
                            {
                                racerAndDistance[name] += int.Parse(item.ToString());
                            }
                        }
                    }
                }
            }
            int places = 0;

            string[] positions = new string[3] { "1st", "2nd", "3rd" };

            foreach (var item in racerAndDistance.OrderByDescending(n => n.Value))
            {
                if (places < 3)
                {
                    Console.WriteLine($"{positions[places]} place: {item.Key}");

                    places++;
                }
                else
                {
                    break;
                }

            }
            
        }
    }
}
