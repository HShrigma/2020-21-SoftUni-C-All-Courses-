using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Robot : Entity
    {
        public Robot(string model, string id)
        {
            this.Name = model;
            this.Id = id;
        }
    }
}
