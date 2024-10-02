using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    class Controller : IController
    {
        private const string validAstronaut0 = "Biologist";
        private const string validAstronaut1 = "Geodesist";        
        private const string validAstronaut2 = "Meteorologist";
        private List<string> valids;

        private int exploredPlanetsCount;
        public Controller()
        {
            exploredPlanetsCount = 0;
            valids = new List<string>() { validAstronaut0, validAstronaut1, validAstronaut2 };
            this.PlanetRepository = new PlanetRepository();
            this.astronautRepository = new AstronautRepository();
        }

        private AstronautRepository astronautRepository;
        private PlanetRepository PlanetRepository;
        public string AddAstronaut(string type, string astronautName)
        {
            if (this.valids.Contains(type))
            {
                IAstronaut astronaut = default;

                switch (type)
                {
                    case validAstronaut0:
                        astronaut = new Biologist(astronautName);
                        break;
                    case validAstronaut1:
                        astronaut = new Geodesist(astronautName);
                        break;
                    case validAstronaut2:
                        astronaut = new Meteorologist(astronautName);
                        break;
                }

                astronautRepository.Add(astronaut);
                return $"Successfully added {type}: {astronautName}!";
            }
            throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            if (items.Length > 0)
            {
                foreach (var item in items)
                {
                    planet.Items.Add(item);
                }
            }
           
            PlanetRepository.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            IPlanet planet = PlanetRepository.Models.FirstOrDefault(n => n.Name == planetName);
            List<IAstronaut> astronauts = astronautRepository.Models.Where(n => n.Oxygen > 60).ToList();

            if (astronauts.Any())
            {
                IMission mission = new Mission();
                mission.Explore(planet, astronauts);
                int deadAstronauts = astronauts.Where(n => n.CanBreath == false).Count();
                this.exploredPlanetsCount++;
                return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
            }

            throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{exploredPlanetsCount} planets were explored!\r\nAstronauts info:");

            foreach (var astronaut in astronautRepository.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}\r\nOxygen: {astronaut.Oxygen}");

                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine($"Bag items: none");
                }
                else
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astronaut.Bag.Items)}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public string RetireAstronaut(string astronautName)
        {
            int count = astronautRepository.Models.Count;
            if (astronautRepository.Remove(astronautRepository.Models.FirstOrDefault(n => n.Name == astronautName)))
            {
                if (count > astronautRepository.Models.Count)
                {
                    return $"Astronaut {astronautName} was retired!";
                }
            }
            throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
        }
    }
}
