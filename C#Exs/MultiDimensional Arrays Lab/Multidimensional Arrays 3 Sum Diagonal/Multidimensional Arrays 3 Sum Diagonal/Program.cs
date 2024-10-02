/* We have a square array of size N
 * our goal is to find the sum of the diagonal elements: 0,0...N,N
 * Input is: 
 * N 
 * N times row
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays_3_Sum_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            //get size
            int n = int.Parse(Console.ReadLine());
            //create empty 2D arr of N size
            int[,] matrix = new int[n, n];
            //create sum var
            int sum = 0;

            for (int rows = 0; rows < n; rows++)
            {
                int[] input = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < n; cols++)
                {
                    if (rows == cols)
                    {
                        sum += input[cols];
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
