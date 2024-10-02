using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (racerOne.IsAvailable() && racerTwo.IsAvailable())
            {
                racerOne.Race();
                racerTwo.Race();
                double racerOneChance = default; 
                double racerTwoChance = default; 
                double racerOneMultiplier = default; 
                double racerTwoMultiplier = default;

                if (racerOne.RacingBehavior == "strict")
                {
                    racerOneMultiplier = 1.2;
                }
                else
                {
                    racerOneMultiplier = 1.1;
                }
                if (racerTwo.RacingBehavior == "strict")
                {
                    racerTwoMultiplier = 1.2;
                }
                else
                {
                    racerTwoMultiplier = 1.1;
                }

                racerOneChance = racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOneMultiplier;
                racerTwoChance = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racerTwoMultiplier;

                IRacer winner = null;

                if (racerOneChance > racerTwoChance)
                {
                    winner = racerOne;
                }
                else
                {
                    winner = racerTwo;
                }

                return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winner.Username} is the winner!";
            }
            else if (racerOne.IsAvailable() && !(racerTwo.IsAvailable()))
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            else if (!(racerOne.IsAvailable()) && racerTwo.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else
            {
                return "Race cannot be completed because both racers are not available!";
            }
        }
    }
}
