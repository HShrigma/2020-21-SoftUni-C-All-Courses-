using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public abstract class Entity
    {
        public virtual int Age { get; set; }
        public virtual string Name { get; set; }
        public virtual string Id { get; set; }

        public virtual string Group { get; set; }
        public virtual string[] Birthday { get; set; }
    }
}
