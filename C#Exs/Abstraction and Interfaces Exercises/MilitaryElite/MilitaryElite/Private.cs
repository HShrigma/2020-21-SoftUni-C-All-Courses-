using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public Private(string firstName, string lastName, string id, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
            this.Salary = salary;
        }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}";
        }
    }
}
