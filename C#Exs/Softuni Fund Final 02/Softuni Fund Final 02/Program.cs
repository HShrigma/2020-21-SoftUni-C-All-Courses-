using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Softuni_Fund_Final_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^\>]+)>([0-9][0-9][0-9])\|([a-z][a-z][a-z])\|([A-Z][A-Z][A-Z])\|([^\<\>][^\<\>][^\<\>])<(\1)";
            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string encrypt = string.Empty;

                    for (int j = 2; j <= 5; j++)
                    {
                        encrypt += match.Groups[j].ToString();
                    }

                    Console.WriteLine("Password: {0}", encrypt);
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
