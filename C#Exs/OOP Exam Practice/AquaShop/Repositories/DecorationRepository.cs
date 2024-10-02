using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> decorations = new List<IDecoration>();
        public IReadOnlyCollection<IDecoration> Models => this.decorations.AsReadOnly();

        public void Add(IDecoration model)
        {
            this.decorations.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            if (this.decorations.Where(n => n.GetType().Name == type).Any())
            {
                return this.decorations.FirstOrDefault(n => n.GetType().Name == type);
            }
            return null;
        }

        public bool Remove(IDecoration model)
        {
            if (this.decorations.Where(n => n.GetType().Name == model.GetType().Name).Any())
            {
                this.decorations.Remove(this.decorations.FirstOrDefault(n => n.GetType().Name == model.GetType().Name));
                return true;
            }
            return false;
        }
    }
}
