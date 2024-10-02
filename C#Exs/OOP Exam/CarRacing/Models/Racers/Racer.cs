using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    {
        protected string _username;
        protected string _racingBehaviour;
        protected int _drivingExperience;
        protected ICar _car;
        protected int _experienceIncrease;

        public Racer(string username, ICar car)
        {
            this.Username = username;
            this.Car = car;
        }
        protected Racer(string username, string racingBehaviour, int drivingExperience, ICar car)
            : this(username, car)
        {
            this.RacingBehavior = racingBehaviour;
            this.DrivingExperience = drivingExperience;
        }
        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username cannot be null or empty.");
                }
                this._username = value;
            }
        }

        public string RacingBehavior
        {
            get
            {
                return this._racingBehaviour;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Racing behavior cannot be null or empty.");
                }
                this._racingBehaviour = value;
            }
        }

        public int DrivingExperience
        {
            get
            {
                return this._drivingExperience;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Racer driving experience must be between 0 and 100.");
                }
                this._drivingExperience = value;
            }
        }

        public ICar Car
        {
            get
            {
                return this._car;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Car cannot be null or empty.");
                }
            }
        }

        public virtual bool IsAvailable()
        {
            if (this.Car.FuelAvailable >= this.Car.FuelConsumptionPerRace)
            {
                return true;
            }

            return false;
        }

        public virtual void Race()
        {
            this.Car.Drive();
            this.DrivingExperience += this._experienceIncrease;
        }
    }
}
