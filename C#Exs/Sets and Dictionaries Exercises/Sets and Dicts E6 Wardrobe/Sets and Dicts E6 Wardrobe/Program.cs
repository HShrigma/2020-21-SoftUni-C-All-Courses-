/* Write a program that helps you decide what clothes to wear from your wardrobe. 
 * You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:
 * "{color} -> {item1},{item2},{item3}…"
 * If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. 
 * You can also receive repeating items for a certain color and you have to keep their count.
 * In the end, you will receive a color and a piece of clothing, 
 * which you will look for in the wardrobe, separated by a space in the following format:
 * "{color} {clothing}"
 * Your task is to print all the items and their count for each color in the following format: 
 * "{color} clothes:
 * * {item1} - {count}
 * * {item2} - {count}
 * * {item3} - {count}
 * …
 * * {itemN} - {count}"
 * If you find the item you are looking for, you need to print "(found!)" next to it:
 * "* {itemN} - {count} (found!)"
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_E6_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            //get N
            int n = int.Parse(Console.ReadLine());
            
            //create empty dictionary of format Key: str - colour, dict<str,int> - articles and count
            Dictionary<string, Dictionary<string,int>> clothes 
                = 
                new Dictionary<string, Dictionary<string,int>>();

            //fill in Dictionary by making sure to add entry if null in dict or nested dict.
            
            for (int i = 0; i < n; i++)
            {
                string[] input = ReadStringArray(" -> ");
                
                string[] articles = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
                
                if (!clothes.ContainsKey(input[0]))
                    clothes.Add(input[0], new Dictionary<string, int>());

                foreach (var piece in articles)
                {
                    if (!clothes[input[0]].ContainsKey(piece))
                        clothes[input[0]].Add(piece, 0);
                    clothes[input[0]][piece]++;
                }
            }

            //get search: colour article
            string[] search = ReadStringArray(" ");

            //print result while searching
            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                
                foreach (var piece in item.Value)
                {
                    string found = string.Empty;

                    if (item.Key == search[0] && piece.Key == search[1])
                        found = " (found!)";

                    Console.WriteLine($"* {piece.Key} - {piece.Value}{found}");
                }
            }
        }

        static string[] ReadStringArray(string separator)
        {
            return Console
                .ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
