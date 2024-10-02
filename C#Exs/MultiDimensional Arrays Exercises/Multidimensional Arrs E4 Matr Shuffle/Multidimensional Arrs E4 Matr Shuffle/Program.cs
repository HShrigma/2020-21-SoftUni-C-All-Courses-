using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrs_E4_Matr_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = ReadStrMatrix();
            bool end = false;
            string invalid = "Invalid input!";
            
            while (end == false)
            {
                string[] command = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "swap":
                        if (command.Length != 5)
                        {
                            Console.WriteLine(invalid);
                        }
                        else
                        {
                            int row1 = int.Parse(command[1]);
                            int col1 = int.Parse(command[2]);
                            int row2 = int.Parse(command[3]);
                            int col2 = int.Parse(command[4]);
                            if (row1 < 0
                                ||
                                row2 < 0
                                ||
                                col1 < 0
                                ||
                                col2 < 0
                                ||
                                row1 > matrix.GetLength(0) - 1
                                ||
                                row2 > matrix.GetLength(0) - 1
                                ||
                                col1 > matrix.GetLength(1) - 1
                                ||
                                col1 > matrix.GetLength(1) - 1
                                )
                            {
                                Console.WriteLine(invalid);
                                break;
                            }

                            string temp = matrix[row1, col1];
                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = temp;
                            printMatrix(matrix);
                        }
                        break;
                    case "END":
                        end = true;
                        break;
                    default:
                        Console.WriteLine(invalid);
                        break;
                }
            }
        }

        static string[,] ReadStrMatrix()
        {
            int[] dimensions = ReadIntArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] input = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }

            return matrix;
        }
        static void printMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[] ReadIntArray()
        {
            return Console
                .ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
