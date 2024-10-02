/* Write program that reads a matrix from console and print the sum for each column. 
 * On first line you will get matrix rows. On the next rows lines, you will get elements 
 * for each column separated with a space. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays_2_Sum_Matrix_Cols
{
    class Program
    {
        static void Main(string[] args)
        {
            //alg:
            //create multidimensional array using user input(int[2] = rows, cols).
            //create sum-tracking array using the cols count as size
            //since we'll move through rows and not cols, we'll use for loops and not foreach
            
            //get matrix size
            int[] sizeOfMatr = ReadIntArray(", ");
            //create empty 2D arr
            int[,] matrix = new int[sizeOfMatr[0], sizeOfMatr[1]];
            //create collumn sum arr where all elements = 0
            int[] colSum = new int[sizeOfMatr[1]];
            for (int i = 0; i < sizeOfMatr[1]; i++)
            {
                colSum[i] = 0;
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                //get row elements
                int[] input = ReadIntArray(" ");

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                    colSum[cols] += input[cols];
                }
            }

            foreach (var sum in colSum)
            {
                Console.WriteLine(sum);
            }
        }
        static int[] ReadIntArray(string separator)
        {
            if (separator == null)
            {
                return Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }
            else
            {
                return Console
                   .ReadLine()
                   .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
            }
        }
    }
}
