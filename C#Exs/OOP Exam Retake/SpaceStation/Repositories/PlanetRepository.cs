using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> planets = new List<IPlanet>();
        public IReadOnlyCollection<IPlanet> Models => this.planets.AsReadOnly();

        public void Add(IPlanet model)
        {
            this.planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            IPlanet planet = this.planets.FirstOrDefault(n => n.Name == name);
            return planet;
        }

        public bool Remove(IPlanet model)
        {
            if (this.planets.Where(n => n.Name == model.Name).Any())
            {
                this.planets.Remove(this.planets.FirstOrDefault(n => n.Name == model.Name));
                return true;
            }
            return false;
        }
    }
}
