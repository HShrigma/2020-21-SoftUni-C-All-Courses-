using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litresPerKm, double tankCapacity)
            : base(fuelQuantity, litresPerKm, tankCapacity)
        {
            this.VehicleType = "Truck";
            this.AC = 1.6;
        }
        public override void Refuel(double litres)
        {

            if (litres <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (litres > 0 && litres + this.Fuel <= this.TankCapacity)
            {
                litres *= 0.95;
                this.Fuel += litres;
            }
            else
            {
                Console.WriteLine($"Cannot fit {litres} fuel in the tank");
            }
        }
    }
}
