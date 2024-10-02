using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string part, int hours)
        {
            this.PartName = part;
            this.Hours = hours;
        }
        public string PartName { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.Hours}";
        }
    }
}
