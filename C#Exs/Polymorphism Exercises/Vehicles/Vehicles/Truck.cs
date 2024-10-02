using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litresPerKm)
            : base(fuelQuantity, litresPerKm)
        {
            this.VehicleType = "Truck";
        }
        private double fuelConsumption;
        public override double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value + 1.6;
            }
        }

        public override void Refuel(double litres)
        {
            this.Fuel += ((litres * 95) / 100);
        }
    }
}
