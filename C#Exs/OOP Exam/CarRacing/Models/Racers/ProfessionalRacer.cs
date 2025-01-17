﻿using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public class ProfessionalRacer : Racer
    {
        public ProfessionalRacer(string username, ICar car)
            : base(username, car)
        {
            this.DrivingExperience = 30;
            this.RacingBehavior = "strict";
            this._experienceIncrease = 10;
        }
    }
}
