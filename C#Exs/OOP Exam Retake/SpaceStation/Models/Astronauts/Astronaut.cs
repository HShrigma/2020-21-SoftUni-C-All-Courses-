using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string _name;
        private double _oxygen;
        private IBag _bag;

        protected Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            _bag = new Backpack();
        }
        public string Name
        {
            get { return _name; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }
                _name = value;
            }
        }

        public double Oxygen
        {
            get
            {
                return _oxygen;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
                this._oxygen = value;
            }
        }

        public bool CanBreath => this.Oxygen > 0;


        public IBag Bag => _bag;

        public virtual void Breath()
        {
            if (this.Oxygen - 10 < 0)
            {
                this.Oxygen = 0;
            }
            else
            {
                this.Oxygen -= 10;
            }
        }
    }
}
