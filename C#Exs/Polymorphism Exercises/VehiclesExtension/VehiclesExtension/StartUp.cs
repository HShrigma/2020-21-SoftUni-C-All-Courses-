using System;
using System.Collections.Generic;
using System.Linq;

namespace VehiclesExtension
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            Car car = new Car(0,0,0);
            Truck truck = new Truck(0,0,0);
            Bus bus = new Bus(0,0,0);

            for (int i = 0; i < 3; i++)
            {
                string[] command = ReadStringArray(" ");

                switch (command[0])
                {
                    case "Car":
                        car = new Car(double.Parse(command[1]), double.Parse(command[2]), double.Parse(command[3]));
                        break;
                    case "Bus":
                        bus = new Bus(double.Parse(command[1]), double.Parse(command[2]), double.Parse(command[3]));
                        break;
                    case "Truck":
                        truck = new Truck(double.Parse(command[1]), double.Parse(command[2]), double.Parse(command[3]));
                        break;
                    default:
                        break;
                }
            }

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string[] command = ReadStringArray(" ");

                switch (command[0])
                {
                    case "Drive":
                        double distance = double.Parse(command[2]);
                        switch (command[1])
                        {
                            case "Car":
                                car.Drive(distance, false);
                                break;
                            case "Bus":
                                bus.Drive(distance, false);
                                break;
                            case "Truck":
                                truck.Drive(distance, false);
                                break;
                        }
                        break;
                    case "Refuel":
                        double litres = double.Parse(command[2]);
                        switch (command[1])
                        {
                            case "Car":
                                car.Refuel(litres);
                                break;
                            case "Bus":
                                bus.Refuel(litres);
                                break;
                            case "Truck":
                                truck.Refuel(litres);
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        bus.Drive(double.Parse(command[2]), true);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(car + "\n" + truck + "\n" + bus);
        }

        static string[] ReadStringArray(string separator)
        {
            return Console
                .ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
