using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        private string missionState;

        public Mission(string codeName, string state)
        {
            this.Codename = codeName;
            this.MissionState = state;
        }
        public string Codename { get; set; }

        public string MissionState
        {
            get { return this.missionState; }
            set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    value = "Invalid";
                }

                this.missionState = value;
            }
        }

        public void CompleteMission()
        {
            this.MissionState = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.Codename} State: {this.MissionState}";
        }
    }
}
