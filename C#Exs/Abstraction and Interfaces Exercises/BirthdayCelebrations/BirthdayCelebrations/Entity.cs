using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public abstract class Entity
    {
        public virtual string Name { get; set; }
        public virtual string Id { get; set; }

        public virtual string[] Birthday { get; set; }
    }
}
