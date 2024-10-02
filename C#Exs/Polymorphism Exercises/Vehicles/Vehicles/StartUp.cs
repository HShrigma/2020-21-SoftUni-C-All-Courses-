using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = ReadStringArray(" ");
            string[] truckInfo = ReadStringArray(" ");

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string[] command = ReadStringArray(" ");

                switch (command[0])
                {
                    case "Drive":
                        if (command[1] == "Car")
                        {
                            car.Drive(double.Parse(command[2]));
                        }
                        else
                        {
                            truck.Drive(double.Parse(command[2]));
                        }
                        break;
                    case "Refuel":
                        if (command[1] == "Car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(car + "\n" + truck);
        }

        static string[] ReadStringArray(string separator)
        {
            return Console
                .ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
