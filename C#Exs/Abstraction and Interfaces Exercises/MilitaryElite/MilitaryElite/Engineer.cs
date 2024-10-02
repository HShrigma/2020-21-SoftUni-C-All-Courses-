using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string firstName, string lastName, string id, decimal salary, string corps)
            : base(firstName, lastName, id, salary, corps)
        {
            this.Corps = corps;
            this.Repairs = new List<Repair>();
        }
        public List<Repair> Repairs { get; set; }

        public override string ToString()
        {
            string corpsCheck;
            if (this.Corps == "Invalid")
            {
                corpsCheck = string.Empty;
            }
            else
            {
                corpsCheck = $"\nCorps: {this.Corps}";
            }
            string repairsCheck;
            if (this.Repairs.Any())
            {
                repairsCheck = "\n  " + string.Join("\n  ", this.Repairs);
            }
            else
            {
                repairsCheck = string.Empty;
            }
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}{corpsCheck}\nRepairs:{repairsCheck}";
        }
    }
}
