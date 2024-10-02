//Write a program that reads continents, countries and their cities,
//puts them in a nested dictionary and prints them.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_4_cities_conts_countr
{
    class Program
    {
        static void Main(string[] args)
        {
            //get n for loops to perform
            int n = int.Parse(Console.ReadLine());

            //create nested dictionary to store continents, countries, and cities
            Dictionary<string, Dictionary<string, List<string>>>
                cityInfo
                = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = ReadStringArray();

                if (!cityInfo.ContainsKey(input[0]))
                {
                    cityInfo.Add(input[0], new Dictionary<string, List<string>>());
                }
                if (!cityInfo[input[0]].ContainsKey(input[1]))
                {
                    cityInfo[input[0]].Add(input[1], new List<string>());
                }
                cityInfo[input[0]][input[1]].Add(input[2]);
            }
            //print in format:
            //continent:
            //  country0 -> city0, ...cityN
            //  ...
            //  countryn -> city0, ...cityN
            foreach (var continent in cityInfo)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }


        }

        static string[] ReadStringArray()
        {
            return Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
