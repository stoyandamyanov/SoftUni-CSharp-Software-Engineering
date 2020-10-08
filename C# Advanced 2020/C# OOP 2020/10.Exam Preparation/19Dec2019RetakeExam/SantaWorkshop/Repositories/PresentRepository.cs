using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaWorkshop.Repositories
{
    public class PresentRepository : IRepository<IPresent>
    {
        private ICollection<IPresent> presents;
        public PresentRepository()
        {
            this.presents = new List<IPresent>();
        }

        public IReadOnlyCollection<IPresent> Models
            => (IReadOnlyCollection<IPresent>)this.presents;

        public void Add(IPresent model)
        {
            this.presents.Add(model);
        }

        public IPresent FindByName(string name)
        {
            IPresent present;

            if(this.presents.Any(p => p.Name == name))
            {
                return present = this.presents.FirstOrDefault(p => p.Name == name);
            }

            return null;
        }

        public bool Remove(IPresent model)
        {
            return this.presents.Remove(model);
        }
    }
}
