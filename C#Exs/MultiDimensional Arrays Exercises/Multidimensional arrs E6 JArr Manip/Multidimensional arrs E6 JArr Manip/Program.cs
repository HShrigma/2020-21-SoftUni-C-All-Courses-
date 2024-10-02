/* We get a Jagged array and populate it N(row count) times
 * we then apply some commands and print that bad boy.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_arrs_E6_JArr_Manip
{
    class Program
    {
        static void Main(string[] args)
        {
            byte size = byte.Parse(Console.ReadLine());

            double[][] jMatrix = new double[size][];

            for (int row = 0; row < jMatrix.Length; row++)
            {
                int[] input = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jMatrix[row] = new double[input.Length];

                for (int col = 0; col < jMatrix[row].Length; col++)
                {
                    jMatrix[row][col] = input[col];
                }
            }

            //analyze
            //if row and row+1 have equal length. Multiply every el by 2. Else divide by 2

            for (int r = 0; r < jMatrix.Length - 1; r++)
            {
                if (jMatrix[r].Length == jMatrix[r+1].Length)
                {
                    for (int i = r; i < r+2; i++)
                    {
                        for (int j = 0; j < jMatrix[i].Length; j++)
                        {
                            jMatrix[i][j] *= 2;
                        }
                    } 
                }
                else
                {
                    for (int i = r; i < r + 2; i++)
                    {
                        for (int j = 0; j < jMatrix[i].Length; j++)
                        {
                            jMatrix[i][j] /= 2;
                        }
                    }
                }
            }

            //check commands:
            //Add - "Add {row} {col} {value}"
            //Subtract - "Subtract {row} {col} {value}"
            //End

            bool end = false;

            while (end == false)
            {
                string[] command = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                    case "Subtract":
                        int row = int.Parse(command[1]);
                        int col = int.Parse(command[2]);
                        long value = long.Parse(command[3]);

                        if (row >= 0 && col >= 0 && row <= jMatrix.Length - 1)
                        {
                            if (col <= jMatrix[row].Length - 1)
                            {
                                if (command[0] == "Add")
                                {
                                    jMatrix[row][col] += value;
                                }
                                else
                                {
                                    jMatrix[row][col] -= value;
                                }
                            }
                        }
                        break;
                    case "End":
                        end = true;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < jMatrix.Length; i++)
            {
                for (int j = 0; j < jMatrix[i].Length; j++)
                {
                    Console.Write(jMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
