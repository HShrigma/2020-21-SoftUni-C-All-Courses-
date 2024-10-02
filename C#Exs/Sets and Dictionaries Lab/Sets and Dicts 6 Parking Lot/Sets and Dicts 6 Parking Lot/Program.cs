/* Write a program that:
 * Records a car number for every car that enters the parking lot
 * Removes a car number when the car leaves the parking lot
 * The input will be a string in the format: "direction, carNumber". 
 * You will be receiving commands, until the "END" command is given.
 * Print the car numbers of the cars, which are still in the parking lot:
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_6_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();
            //set end token
            bool end = false;

            while (!end)
            {
                string[] input = ReadStringArray();

                switch (input[0])
                {
                    case "IN":
                        parking.Add(input[1]);
                        break;
                    case "OUT":
                        parking.Remove(input[1]);
                        break;
                    case "END":
                        end = true;
                        break;
                }
            }

            if (parking.Any())
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }

        static string[] ReadStringArray()
        {
            return Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
