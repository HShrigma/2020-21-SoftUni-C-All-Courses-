using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<Models.Cars.Contracts.ICar>
    {
        public IReadOnlyCollection<Models.Cars.Contracts.ICar> Models { get; set; }

        public void Add(Models.Cars.Contracts.ICar car)
        {
            List<Models.Cars.Contracts.ICar> cars = Models.ToList();
            cars.Add(car);
        }

        public Models.Cars.Contracts.ICar FindBy(string property)
        {
            foreach (var item in this.Models)
            {
                if (item.VIN == property)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Remove(Models.Cars.Contracts.ICar car)
        {
            if (this.Models.Any(n => n == car))
            {
                this.Models = this.Models.Where(n => n != car).ToList().AsReadOnly();
                return true;
            }
            return false;
        }
    }
}
