/* Write a program that reads a matrix from the console. 
 * On the first line you will get matrix rows. On next rows lines you will get elements 
 * for each column separated with space. 
 * You will be receiving commands in the following format:
 * Add {row} {col} {value} – Increase the number at the given coordinates with the value.
 * Subtract {row} {col} {value} – Decrease the number at the given coordinates by the value.
 * Coordinates might be invalid. 
 * In this case you should print "Invalid coordinates". 
 * When you receive "END" you should print the matrix and stop the program.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays_6_modJarr
{
    class Program
    {
        static void Main(string[] args)
        {
            //init jagged array
            int[][] jagged = ReadJaggedIntArray();

            //get commands
            //possible commands:
            //Add {x} {y} {value} - Add value to element at coordinates
            //Subtract {x} {y} {value} - Subtract value to element at coordinats
            //if coordinates do not exist:
            //print "Invalid coordinates"
            //if command = "END", stop loop
            string[] command = new string[4];
            command[0] = string.Empty;

            while (command[0] != "END")
            {
                command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Add":
                        if (jagged.Length - 1 >= int.Parse(command[1]) && int.Parse(command[1]) >= 0)
                        {
                            if (jagged[int.Parse(command[1])].Length >= int.Parse(command[2]) && int.Parse(command[2]) >= 0)
                            {
                                jagged[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid coordinates");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if (jagged.Length - 1 >= int.Parse(command[1]) && int.Parse(command[1]) >= 0)
                        {
                            if (jagged[int.Parse(command[1])].Length >= int.Parse(command[2]) && int.Parse(command[2]) >= 0)
                            {
                                jagged[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid coordinates");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }

        static int[][] ReadJaggedIntArray()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagarr = new int[n][];

            for (int rows = 0; rows < n; rows++)
            {
                int[] input = ReadIntArray();
                jagarr[rows] = new int[input.Length];
                
                for (int cols = 0; cols < input.Length; cols++)
                {
                    jagarr[rows][cols] = input[cols]; 
                }
            }

            return jagarr;
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
