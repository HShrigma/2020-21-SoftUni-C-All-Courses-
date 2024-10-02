using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarRacing.Models.Cars
{
    public abstract class Car : ICar
    {
        protected string _make;
        protected string _model;
        protected string _vIN;
        protected int _horsePower;
        protected double _fuelAvailable;
        protected double _fuelConsumptionPerRace;

        public Car(string make, string model, string VIN, int horsePower)

        {
            this.Make = make;
            this.Model = model;
            this.VIN = VIN;
            this.HorsePower = horsePower;
        }
        protected Car(string make, string model, string VIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
            : this(make, model, VIN, horsePower)
        {
            this.FuelAvailable = fuelAvailable;
            this.FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        

        public string Make
        {
            get { return this._make; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Car make cannot be null or empty.");
                }
                this._make = value;
            }
        }

        public string Model
        {
            get
            {
                return this._model;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Car model cannot be null or empty.");
                }
                this._model = value;
            }
        }

        public string VIN
        {
            get
            {
                return this._vIN;
            }
            set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException("Car VIN must be exactly 17 characters long.");
                }
                this._vIN = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this._horsePower;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Horse power cannot be below 0.");
                }
                this._horsePower = value;
            }
        }

        public double FuelAvailable
        {
            get
            {
                return this._fuelAvailable;
            }
            set
            {
                if (value < 0)
                {
                    this._fuelAvailable = 0;
                }
                else
                {
                    this._fuelAvailable = value;
                }
            }
        }

        public double FuelConsumptionPerRace
        {
            get
            {
                return this._fuelConsumptionPerRace;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel consumption cannot be below 0.");
                }
            }
        }
        public virtual void Drive()
        {
            this.FuelAvailable -= this._fuelConsumptionPerRace;
        }
    }
}
