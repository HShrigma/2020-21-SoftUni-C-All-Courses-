using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litresPerKm, double tankCapacity)
            : base(fuelQuantity, litresPerKm, tankCapacity)
        {
            this.VehicleType = "Bus";
            this.AC = 1.4;
        }
    }
}
