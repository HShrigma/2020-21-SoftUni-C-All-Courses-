using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab_03_Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> merged = FillSmallerIntListToBigger(first, second);

            Console.WriteLine(string.Join(" ", merged));
        }

        static List<int> FillSmallerIntListToBigger(List<int> first, List<int> second)
        {
            if (first.Count <= second.Count)
            {
                int pos = 0;
                for (int i = 0; i < first.Count; i ++)
                {
                    second.Insert(pos, first[i]);
                    pos += 2;
                }

                return second;
            }
            else 
            {
                int pos = 1;
                for (int i = 0; i < second.Count; i++)
                {
                    first.Insert(pos, second[i]);

                    pos += 2;
                }
                return first;
            }


        }
    }
}