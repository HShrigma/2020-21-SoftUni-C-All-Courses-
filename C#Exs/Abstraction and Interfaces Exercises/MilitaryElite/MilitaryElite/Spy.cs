using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Spy: Soldier, ISpy
    {
        public Spy(string firstName, string lastName, string id, int codeNumber)
        {
            this.FirstName = firstName;
            this.FirstName = lastName;
            this.ID = id;
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID}\nCode Number: {this.CodeNumber}";
        }
    }
}
