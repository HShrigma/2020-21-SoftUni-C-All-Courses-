using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral: Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string firstName, string lastName, string id, decimal salary)
            : base(firstName,lastName,id, salary)
        {
            this.Privates = new List<Soldier>();
        }
        public List<Soldier> Privates { get; set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}\nPrivates:\n  {string.Join("\n  ", this.Privates)}";
        }
    }
}
