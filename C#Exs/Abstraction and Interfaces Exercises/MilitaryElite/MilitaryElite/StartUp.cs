using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    /*"Private <id> <firstName> <lastName> <salary>"
                    "LieutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>" where privateXId will always be an Id of a Private already received through the input.
                    "Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>" where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it (the two parameters will always come paired)
                    "Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>" a missions code name, description and state will always come together.
                    "Spy <id> <firstName> <lastName> <codeNumber>"
                     */
                    case "Private":
                        Private @private = new Private(command[2], command[3], command[1], decimal.Parse(command[4]));
                        soldiers.Add(@private);
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral lieutenant = new LieutenantGeneral(command[2], command[3], command[1], decimal.Parse(command[4]));
                        lieutenant.Privates = GetPrivates(5, command, soldiers);
                        soldiers.Add(lieutenant);
                        break;
                    case "Engineer":
                        Engineer engineer = new Engineer(command[2], command[3], command[1], decimal.Parse(command[4]), command[5]);
                        engineer.Repairs = GetRepairs(6, command);
                        soldiers.Add(engineer);
                        break;
                    case "Commando":
                        Commando commando = new Commando(command[2], command[3], command[1], decimal.Parse(command[4]), command[5]);
                        commando.Missions = GetMissions(6, command);
                        soldiers.Add(commando);
                        break;
                    case "Spy":
                        Spy spy = new Spy(command[2], command[3], command[1], int.Parse(command[4]));
                        soldiers.Add(spy);
                        break;
                    default:
                        break;
                }
            }

            soldiers.ForEach(n => Console.WriteLine(n));
        }

        static List<Soldier> GetPrivates(int startIndex, string[] commandArr, List<Soldier> toSearch)
        {
            List<Soldier> privates = new List<Soldier>();

            for (int i = startIndex; i < commandArr.Length; i++)
            {
                if (toSearch.Any(n => n.ID == commandArr[i]))
                {
                    privates.Add(toSearch.Find(n => n.ID == commandArr[i]));
                }
            }

            return privates;
        }

        static List<Repair> GetRepairs(int startIndex, string[] commandArr)
        {
            List<Repair> repairs = new List<Repair>();

            for (int i = startIndex; i < commandArr.Length; i += 2)
            {
                Repair temp = new Repair(commandArr[i], int.Parse(commandArr[i + 1]));
                repairs.Add(temp);
            }
            return repairs;
        }

        static List<Mission> GetMissions(int startIndex, string[] commandArr)
        {
            List<Mission> missions = new List<Mission>();

            for (int i = startIndex; i < commandArr.Length; i += 2)
            {
                Mission mission = new Mission(commandArr[i], commandArr[i + 1]);
                missions.Add(mission);
            }

            return missions;
        }
    }
}
