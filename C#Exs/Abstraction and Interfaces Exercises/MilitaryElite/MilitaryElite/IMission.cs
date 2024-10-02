using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IMission
    {
        public string Codename { get; set; }

        public string MissionState { get; set; }

        public void CompleteMission();
    }
}
