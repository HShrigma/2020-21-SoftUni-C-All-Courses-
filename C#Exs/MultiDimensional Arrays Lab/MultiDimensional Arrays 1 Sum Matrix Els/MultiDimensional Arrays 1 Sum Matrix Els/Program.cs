/*Write program that reads a matrix from the console and print:
 * Count of rows
 * Count of columns
 * Sum of all matrix elements
 * On first line you will get matrix sizes in format [rows, columns]
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiDimensional_Arrays_1_Sum_Matrix_Els
{
    class Program
    {
        static void Main(string[] args)
        {
            //get matrix size with User Input
            int[] sizeOfMatr = ReturnIntArray();

            //create 2D array of said sizes
            int[,] matrix = new int[sizeOfMatr[0], sizeOfMatr[1]];
            //keep trac of arr element sum
            int sum = default;
            //alg:
            //for each row we get user input for the array ex: el1, el2, el3, ...eln (n elements sep. by ", ")
            //we then feed it to each column of said row from index 0 to n-1
            //keeping track of sum x: x = x + el0...eln

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currentRow = ReturnIntArray();
                
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = currentRow[cols];
                    sum += matrix[rows, cols];
                }
            }

            //print rows, columns, and sum of arr
            Console.WriteLine($"{sizeOfMatr[0]}\n{sizeOfMatr[1]}\n{sum}");
        }

        static int[] ReturnIntArray()
        {
            return Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
