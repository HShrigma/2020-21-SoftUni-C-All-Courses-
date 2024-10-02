using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab_05_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> positivesAndNegatives = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool positivesExist = false;

            List<int> OnlyPositives = new List<int>();
            
            for (int i = 0; i < positivesAndNegatives.Count; i++)
            {
                if (positivesAndNegatives[i] >= 0)
                {
                    positivesExist = true;

                    OnlyPositives.Add(positivesAndNegatives[i]);
                }
            }

            CheckListAndPrintReverseOrEmpty(positivesExist, OnlyPositives);
        }

        static void CheckListAndPrintReverseOrEmpty(bool listExists, List<int> ToPrint)
        {

            if (listExists == true)
            {
                ToPrint.Reverse();

                Console.WriteLine(string.Join(" ", ToPrint));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
