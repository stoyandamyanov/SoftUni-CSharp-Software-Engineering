using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models
            => this.models.AsReadOnly();

        public void Add(IGun model)
        {
            if (model != null)
            {
                models.Add(model);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }

        }

        public IGun FindByName(string name)
        {
            var gun = this.models.FirstOrDefault(p => p.Name == name);

            if(gun != null)
            {
                return gun;
            }
            else
            {
                return null;
            }
            
        }

        public bool Remove(IGun model)
        {
            if (this.models.Contains(model))
            {
                this.models.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
