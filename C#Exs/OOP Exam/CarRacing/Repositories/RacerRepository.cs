using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<Models.Racers.Contracts.IRacer>
    {
        public IReadOnlyCollection<Models.Racers.Contracts.IRacer> Models { get; set; }

        public void Add(Models.Racers.Contracts.IRacer racer)
        {
            if (racer == null)
            {
                throw new ArgumentException("Cannot add null in Racer Repository");
            }
            List<Models.Racers.Contracts.IRacer> racers = Models.ToList();
            racers.Add(racer);

            this.Models = racers.AsReadOnly();
        }

        public Models.Racers.Contracts.IRacer FindBy(string property)
        {
            foreach (var item in this.Models)
            {
                if (item.Username == property)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Remove(Models.Racers.Contracts.IRacer racer)
        {
            if (this.Models.Any(n => n == racer))
            {
                this.Models = this.Models.Where(n => n != racer).ToList().AsReadOnly();
                return true;
            }
            return false;
        }
    }
}
