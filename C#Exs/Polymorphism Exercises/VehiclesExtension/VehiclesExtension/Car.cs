using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litresPerKm, double tankCapacity)
            : base(fuelQuantity, litresPerKm,tankCapacity)
        {
            this.VehicleType = "Car";
            this.AC = 0.9;
        }
    }
}
