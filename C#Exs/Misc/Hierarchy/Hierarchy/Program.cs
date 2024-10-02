using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            List <Car> cars = new List<Car>();
            string input = string.Empty;

            for (int i = 0; i < loops; i++)
            {
                input = Console.ReadLine(); // {Model} On/Off, "You just started your {Model}"


                string[] command = input.Split();

                bool exists = false;
               
                foreach (var item in cars)
                {
                    if (item.Model == command[0])
                    {
                        exists = true;

                        if (command[1] == "On")
                        {
                            Console.WriteLine($"You just started your {item.Model}");
                            break;
                        }
                       
                        else
                        {
                            item.OnOrOff = false;
                            break;
                        }
                    }
                }

                if (!(exists))
                {
                    Car temp = new Car()
                    {
                        Model = command[0]
                    };

                    if (command[1] == "On")
                    {
                        temp.OnOrOff = true;
                    }

                    else
                    {
                        temp.OnOrOff = false;
                    }

                    cars.Add(temp);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}: {car.OnOrOff}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }

        public bool OnOrOff { get; set; }
    }

}
