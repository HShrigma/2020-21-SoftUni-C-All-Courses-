using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public abstract class Entity
    {
        public virtual string Name { get; set; }
        public virtual string Id { get; set; }
    }
}
