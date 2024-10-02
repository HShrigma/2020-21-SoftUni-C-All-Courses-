/* We get a square 2D array of N size and find the sums of both diagonals and we find the abs diff between both
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrs_E1_Diag_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            //get N
            int n = int.Parse(Console.ReadLine());
            //create empty matrix
            int[,] matrix = new int[n,n];
            //fill in diag sums by referencing column index with diag counters
            int leftDiag = 0; //top left diagonal will start from first index
            int rightDiag = n - 1; //top right diag will start from last index
            int lDSum = 0;
            int rDSum = 0;

            for (int rows = 0; rows < n; rows++)
            {
                int[] inputLine = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                bool rightFound = false;
                bool leftFound = false;

                for (int cols = 0; cols < n; cols++)
                {
                    //fill in matrix and check for sums
                    matrix[rows, cols] = inputLine[cols];

                    if (cols == leftDiag && leftFound == false)
                    {
                        lDSum += inputLine[cols];
                        leftDiag++;
                        leftFound = true;
                    }

                    if (cols == rightDiag && rightFound == false)
                    {
                        rDSum += inputLine[cols];
                        rightDiag--;
                        rightFound = true;
                    }
                }
            }

            //print result based on which diagonal sum is higher

            Console.WriteLine(Math.Abs(lDSum - rDSum));
        }
    }
}
