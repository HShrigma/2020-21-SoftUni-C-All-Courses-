using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxList = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                boxList.Add(new Box<double>(double.Parse(input)));
            }

            string comparer = Console.ReadLine();

            Console.WriteLine(boxList[0].GreaterThanCount(double.Parse(comparer), boxList));
        }
    }
}