using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class TunedCar : Car
    {
        public TunedCar(string make, string model, string VIN, int horsePower)
            : base(make, model, VIN, horsePower)
        {
            this.FuelAvailable = 65;
            this.FuelConsumptionPerRace = 7.5;
        }

        public override void Drive()
        {
            this.FuelAvailable -= this.FuelConsumptionPerRace;
            this.HorsePower -= (int)Math.Round((0.03 * this.HorsePower), 0, MidpointRounding.AwayFromZero);
        }
    }
}
