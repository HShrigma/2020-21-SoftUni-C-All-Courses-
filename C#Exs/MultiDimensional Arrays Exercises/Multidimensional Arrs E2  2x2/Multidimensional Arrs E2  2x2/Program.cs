/* So we have a matrix and we gotta find each 2x2 submatrix of equal chars.
 * If none exists, print 0.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrs_E2__2x2
{
    class Program
    {
        static void Main(string[] args)
        {
            //get sizes
            int[] sizes = ReadIntArray();

            //create empty matrix of sizes[]
            char[,] matrix = new char[sizes[0], sizes[1]];

            //count 2x2 arrays
            int counter = default;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    char temp = matrix[rows, cols];
                    bool check = true;

                    for (int subR = 0; subR < 2; subR++)
                    {
                        for (int SubC = 0; SubC < 2; SubC++)
                        {
                            if (matrix[rows + subR, cols + SubC] != temp)
                            {
                                check = false;
                                break;
                            }
                        }
                    }

                    if (check == true)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        static int[] ReadIntArray()
        {
            return Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
