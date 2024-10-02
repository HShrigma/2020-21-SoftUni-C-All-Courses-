using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public virtual int Quantity { get; set; }
    }
}
