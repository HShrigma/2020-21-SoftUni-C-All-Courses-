using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary,  string corps)
            : base(firstName, lastName, id, salary)
        {
            this.Corps = corps;
        }
        public virtual string Corps 
        {
            get 
            {
                return this.corps;
            }
            set
            {
                if (value != "Marines" && value != "Airforces")
                {
                    value = "Invalid";
                }
                this.corps = value;
            }
        }
    }
}
