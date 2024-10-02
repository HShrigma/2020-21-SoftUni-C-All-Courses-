using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MilitaryElite
{
    class Commando: SpecialisedSoldier, ICommando
    {
        public Commando(string firstName, string lastName, string id, decimal salary, string corps)
            : base(firstName, lastName, id, salary, corps)
        {
            this.Corps = corps;
            this.Missions = new List<Mission>();
        }
        public List<Mission> Missions { get; set; }

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

            string missionCheck;
            if (this.Missions.Any(n => n.MissionState != "Invalid"))
            {
                missionCheck = "\n  " + string.Join("\n  ", this.Missions.Where(n => n.MissionState != "Invalid"));
            }
            else
            {
                missionCheck = string.Empty;
            }
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}{corpsCheck}\nMissions:{missionCheck}";
        }
    }
}
