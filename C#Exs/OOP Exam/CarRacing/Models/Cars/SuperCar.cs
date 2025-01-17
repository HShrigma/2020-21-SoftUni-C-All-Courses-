﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        public SuperCar(string make, string model, string VIN, int horsePower)
            :base(make, model, VIN, horsePower)
        {
            this.FuelAvailable = 80;
            this.FuelConsumptionPerRace = 10;
        }
    }
}
