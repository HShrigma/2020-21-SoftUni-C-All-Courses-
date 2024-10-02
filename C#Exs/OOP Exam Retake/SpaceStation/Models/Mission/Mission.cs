using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            while (true)
            {
                var currentAstronaut = astronauts.FirstOrDefault(x => x.CanBreath);

                if (currentAstronaut is null)
                {
                    break;
                }

                var currentItem = planet.Items.FirstOrDefault();

                if (currentItem == null)
                {
                    break;
                }

                currentAstronaut.Breath();

                currentAstronaut.Bag.Items.Add(currentItem);
                planet.Items.Remove(currentItem);
            }
        }
    }
}
