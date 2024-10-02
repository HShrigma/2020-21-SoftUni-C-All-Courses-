using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private List<IAstronaut> astronauts = new List<IAstronaut>();
        public IReadOnlyCollection<IAstronaut> Models => this.astronauts.AsReadOnly();

        public void Add(IAstronaut model)
        {
            this.astronauts.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            if (this.astronauts.Where(n => n.Name == name).Any())
            {
                return this.astronauts.FirstOrDefault(n => n.Name == name);
            }
            return null;
        }

        public bool Remove(IAstronaut model)
        {
            if (this.astronauts.Where(n => n.Name == model.Name).Any())
            {
                this.astronauts.Remove(this.astronauts.FirstOrDefault(n => n.Name == model.Name));
                return true;
            }
            return false;
        }
    }
}
