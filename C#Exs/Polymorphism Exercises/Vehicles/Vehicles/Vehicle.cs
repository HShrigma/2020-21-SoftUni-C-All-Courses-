using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {

        public Vehicle(double fuelQuantity, double litresPerKm)
        {
            this.Fuel = fuelQuantity;
            this.FuelConsumption = litresPerKm;
        }
        public virtual string VehicleType { get; set; }
        public virtual double Travelled { get; set; }
        public virtual double Fuel { get; set; }

        public abstract double FuelConsumption { get; set; }

        public virtual void Drive(double distance)
        {
            double loss = distance * this.FuelConsumption;
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
            this.Fuel += litres;
        }

        public override string ToString()
        {
            return $"{this.VehicleType}: {this.Fuel:F2}";
        }
    }
}
