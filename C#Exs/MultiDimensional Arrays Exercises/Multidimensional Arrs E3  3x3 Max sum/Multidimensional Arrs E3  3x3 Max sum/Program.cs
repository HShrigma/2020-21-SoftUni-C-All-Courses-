using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrs_E3__3x3_Max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = ReadMatrix();

            int[,] maxSub = new int[3, 3];

            int maxSum = int.MinValue;

            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {
                    int tempSum = 0;
                    int[,] tempMatr = new int[3, 3];

                    for (int subR = 0; subR < 3; subR++)
                    {
                        for (int subC = 0; subC < 3; subC++)
                        {
                            tempMatr[subR, subC] = matrix[rows + subR, cols + subC];
                            tempSum += tempMatr[subR, subC];
                        }
                    }

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxSub = tempMatr;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int rows = 0; rows < maxSub.GetLength(0); rows++)
            {
                for (int cols = 0; cols < maxSub.GetLength(1); cols++)
                {
                    Console.Write(maxSub[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] ReadMatrix()
        {
            int[] sizes = ReadIntArray();
            int[,] matr = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matr.GetLength(0); row++)
            {
                int[] input = ReadIntArray();

                for (int col = 0; col < matr.GetLength(1); col++)
                {
                    matr[row, col] = input[col];
                }
            }

            return matr;
        }

        static int[] ReadIntArray()
        {
            return Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
