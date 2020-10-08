using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IDecoration> decorations;
        private readonly List<IAquarium> aquariums;
        public Controller()
        {
            this.aquariums = new List<IAquarium>();
            this.decorations = new DecorationRepository();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;

            if (aquariumType == nameof(FreshwaterAquarium))
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == nameof(SaltwaterAquarium))
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
            this.aquariums.Add(aquarium);

            return $"{string.Format(OutputMessages.SuccessfullyAdded, aquariumType)}";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration;

            if (decorationType == nameof(Ornament))
            {
                decoration = new Ornament();
            }
            else if (decorationType == nameof(Plant))
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            decorations.Add(decoration);

            return $"{string.Format(OutputMessages.SuccessfullyAdded, decorationType)}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decoration = this.decorations.FindByType(decorationType);
            var aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            aquarium.AddDecoration(decoration);
            decorations.Remove(decoration);

            return $"{string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName)}";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
           
            IFish fish;

            if (fishType == nameof(FreshwaterFish))
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if(fishType == nameof(SaltwaterFish))
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            if(fish.GetType().Name == nameof(FreshwaterFish) && aquarium.GetType().Name != nameof(FreshwaterAquarium))
            {
                return OutputMessages.UnsuitableWater;
            }
            else if(fish.GetType().Name == nameof(SaltwaterFish) && aquarium.GetType().Name != nameof(SaltwaterAquarium))
            {
                return OutputMessages.UnsuitableWater;
            }

            aquarium.AddFish(fish);

            return $"{string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName)}";
        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if(aquarium != null)
            {
                foreach (var fish in aquarium.Fish)
                {
                    fish.Eat();
                }
            }

            return $"{string.Format(OutputMessages.FishFed, aquarium.Fish.Count)}";
        }

        public string CalculateValue(string aquariumName)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            var fishesTotalSum = aquarium.Fish.Sum(f => f.Price);
            var decorationsTotalSum = aquarium.Decorations.Sum(d => d.Price);
            var totalSum = fishesTotalSum + decorationsTotalSum;

            return $"{string.Format(OutputMessages.AquariumValue, aquariumName,totalSum)}";
        }


        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aqa in aquariums)
            {
                sb.AppendLine(aqa.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
