/* Write a program that reads N, number representing rows and cols of a matrix. 
 * On the next N lines, you will receive rows of the matrix. 
 * Each row consists of ASCII characters. After that, you will receive a symbol. 
 * Find the first occurrence of that symbol in the matrix and print its position in the format: 
 * "({row}, {col})". If there is no such symbol print an error message:
 * "{symbol} does not occur in the matrix "
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays_4_Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            //get int N
            int n = int.Parse(Console.ReadLine());

            //create empty char matrix of sizes: n,n 
            char[,] matrix = new char[n, n];
            //fill matrix
            for (int rows = 0; rows < n; rows++)
            {
                string row = Console.ReadLine();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = row[cols];
                }
            }

            //get magic symbol
            char magic = char.Parse(Console.ReadLine());
            //set "found" condition
            List<int> found = new List<int>();

            //search for magic symbol

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (matrix[rows, cols] == magic)
                    {
                        found.Add(rows);
                        found.Add(cols);
                        break;
                    }
                }
            }
            //print result based on list size
            if (found.Any())
            {
                Console.WriteLine($"({found[0]}, {found[1]})");
            }
            else
            {
                Console.WriteLine($"{magic} does not occur in the matrix ");
            }
        }
    }
}
