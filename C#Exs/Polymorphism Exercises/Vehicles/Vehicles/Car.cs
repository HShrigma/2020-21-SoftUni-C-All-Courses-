using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litresPerKm)
            : base(fuelQuantity, litresPerKm)
        {
            this.VehicleType = "Car";
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
                this.fuelConsumption = value + 0.9;
            }
        }
    }
}
