using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Merge_2_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //init values
            List<int> randomListA = CreateListofRandomLengthAndElements();
            Console.WriteLine($"List A: {String.Join(" ", randomListA)}");
            List<int> randomListB = CreateListofRandomLengthAndElements();
            Console.WriteLine($"List B: {String.Join(" ", randomListB)}");

            List<int> MergedList = MergeLists(randomListA, randomListB);
            Console.WriteLine($"Merged List: {String.Join(" ", MergedList)}");
        }

        static List<int> CreateListofRandomLengthAndElements()
        {
            List<int> rand = new List<int>();
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 11); i++)
            {
                rand.Add(random.Next(1, 51));
            }
            rand.Sort();
            return rand;
        }
        static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            List<int> mergedList = new List<int>();
            int i = 0;
            int j = 0;
            while (i != list1.Count || j != list2.Count)
            {
                if (i == list1.Count)
                {
                    mergedList.Add(list2[j]);
                    j++;
                }
                else if (j == list2.Count)
                {
                    mergedList.Add(list1[i]);
                    i++;
                }
                else
                {
                    if (list1[i] > list2[j])
                    {
                        mergedList.Add(list2[j]);
                        j++;
                    }
                    else if (list2[j] > list1[i])
                    {
                        mergedList.Add(list1[i]);
                        i++;
                    }
                    else
                    {
                        mergedList.Add(list1[i]);
                        mergedList.Add(list2[j]);
                        i++;
                        j++;
                    }
                }

            }
            return mergedList;
        }
    }
}
