/* We're making a Pascal triangle with jagged arrays
 * so a pascal triangle is the following:
 * we start from 1, move one line below
 * each next entry: entry[n][n] = entry[n-1][n-1] + entry[n-1][n]
 * if an entry is blank we treat it as 0
 * we only get line input
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays_7_Pascal_Tr
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number of lines
            int n = int.Parse(Console.ReadLine());
            ulong[][] triangle = new ulong[n][];

            for (int rows = 0; rows < n; rows++)
            {
                triangle[rows] = new ulong[rows + 1];

                for (int cols = 0; cols < triangle[rows].Length; cols++)
                {
                    ulong  sum = 1;
                    //check if:
                    //this isn't the first or last in a row
                    //and if this isn't the first row
                    if (cols > 0 && rows > 0 && cols != triangle[rows].Length - 1)
                    {
                        sum = triangle[rows - 1][cols - 1] + triangle[rows - 1][cols];
                    }
                    triangle[rows][cols] = sum;
                }
                Console.WriteLine(string.Join(' ', triangle[rows]));
            }
        }
    }
}
