using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private const string validAquarium0 = "FreshwaterAquarium";
        private const string validAquarium1 = "SaltwaterAquarium";
       
        private const string validDecoration0 = "Ornament";
        private const string validDecoration1 = "Plant";

        private const string validFish0 = "FreshwaterFish";
        private const string validFish1 = "SaltwaterFish";

        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            aquariums = new List<IAquarium>();
            decorations = new DecorationRepository();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == validAquarium0 || aquariumType == validAquarium1)
            {
                if (aquariumType == validAquarium0)
                {
                    aquariums.Add(new FreshwaterAquarium(aquariumName));
                }
                else
                {
                    aquariums.Add(new SaltwaterAquarium(aquariumName));
                }
                return $"Successfully added {aquariumType}.";
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType == validDecoration0 || decorationType == validDecoration1)
            {
                if (decorationType == validDecoration0)
                {
                    decorations.Add(new Ornament());
                }
                else
                {
                    decorations.Add(new Plant());
                }
                return $"Successfully added {decorationType}.";
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
        }
        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType == validFish0 || fishType == validFish1)
            {
                string aquariumType = aquariums.FirstOrDefault(n => n.Name == aquariumName).GetType().Name;
                bool success = default;
                switch (aquariumType)
                {
                    case validAquarium0:
                        if (fishType == validFish0)
                        {
                            aquariums.FirstOrDefault(n => n.Name == aquariumName)
                                .AddFish(new FreshwaterFish(fishName, fishSpecies, price));
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
                        break;
                    case validAquarium1:
                        if (fishType == validFish1)
                        {
                            aquariums.FirstOrDefault(n => n.Name == aquariumName)
                                .AddFish(new SaltwaterFish(fishName, fishSpecies, price));
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
                        break;
                    default:
                        throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
                }
                if (success)
                {
                    return $"Successfully added {fishType} to {aquariumName}.";
                }
                return OutputMessages.UnsuitableWater;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
        }

        public string CalculateValue(string aquariumName)
        {
            decimal value = 0.0m;
            value += aquariums.FirstOrDefault(n => n.Name == aquariumName).Fish.Sum(n => n.Price);
            value += aquariums.FirstOrDefault(n => n.Name == aquariumName).Decorations.Sum(n => n.Price);
            return $"The value of Aquarium {aquariumName} is {value:F2}.";
        }

        public string FeedFish(string aquariumName)
        {
            int counter = 0;

            foreach (IFish fish in aquariums.FirstOrDefault(n => n.Name == aquariumName).Fish)
            {
                fish.Eat();
                counter++;
            }

            return $"Fish fed: {counter}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            if (decorations.Models.Where(n => n.GetType().Name == decorationType).Any())
            {
                if (decorationType == validDecoration0)
                {
                    aquariums.FirstOrDefault(n => n.Name == aquariumName).AddDecoration(new Ornament());
                }
                else
                {
                    aquariums.FirstOrDefault(n => n.Name == aquariumName).AddDecoration(new Plant());
                }
                decorations.Remove(decorations.FindByType(decorationType));
                return $"Successfully added {decorationType} to {aquariumName}.";
            }
            else
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }
        }

        public string Report()
        {
            string report = string.Empty;
            List<IAquarium> aquaria = aquariums.ToList();
            for (int i = 0; i < aquariums.Count; i++)
            {
                if (i < aquariums.Count - 1)
                    report += aquaria[i].GetInfo() + "\n";
                else report += aquaria[i].GetInfo();
            }
            return report;
        }
    }
}
