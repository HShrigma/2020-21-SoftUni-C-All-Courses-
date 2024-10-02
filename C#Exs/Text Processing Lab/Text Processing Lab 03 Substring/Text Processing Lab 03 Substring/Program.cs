using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing_Lab_03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();

            string toSubStr = Console.ReadLine();

            while (toSubStr.Contains(toRemove))
            {
               toSubStr = toSubStr.Remove(toSubStr.IndexOf(toRemove), toRemove.Length);
            }

            Console.WriteLine(toSubStr);
        }
    }
}
