using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double litresPerKm, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.Fuel = 0;
            }
            else
            {
                this.Fuel = fuelQuantity;

            }
            this.FuelConsumption = litresPerKm;
            this.TankCapacity = tankCapacity;
        }
        public virtual string VehicleType { get; set; }
        public virtual double Travelled { get; set; }
        public virtual double Fuel { get; set; }

        public virtual double AC { get; set; }
        public virtual double TankCapacity { get; set; }
        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double distance, bool empty)
        {
            double loss;

            if (empty)
            {
                loss = distance * this.FuelConsumption;
            }
            else
            {
                loss = distance * (this.FuelConsumption + this.AC);
            }

            if (this.Fuel - loss >= 0)
            {
                this.Fuel -= loss;
                Console.WriteLine($"{this.VehicleType} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.VehicleType} needs refueling");
            }
        }

        public virtual void Refuel(double litres)
        {
            if (litres <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (litres > 0 && litres + this.Fuel <= this.TankCapacity)
            {
                this.Fuel += litres;
            }
            else
            {
                Console.WriteLine($"Cannot fit {litres} fuel in the tank");
            }

        }

        public override string ToString()
        {
            return $"{this.VehicleType}: {this.Fuel:F2}";
        }
    }
}
