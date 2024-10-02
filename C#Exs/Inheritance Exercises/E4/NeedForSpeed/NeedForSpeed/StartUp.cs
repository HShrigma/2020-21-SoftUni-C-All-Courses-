using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(150, 800);
            Car car = new Car(150, 800);
            SportCar sportCar = new SportCar(150, 800);
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(150, 800);
            vehicle.Drive(750);
            car.Drive(750);
            sportCar.Drive(750);
            raceMotorcycle.Drive(750);
            Console.WriteLine(vehicle.Fuel);
            Console.WriteLine(car.Fuel);
            Console.WriteLine(sportCar.Fuel);
            Console.WriteLine(raceMotorcycle.Fuel);
        }
    }
}
