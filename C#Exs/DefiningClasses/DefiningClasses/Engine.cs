using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        //T04
        /*
        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public string Model { get { return model; } set { model = value; } }
        public string Power { get { return power; } set { power = value; } }
        public string Displacement { get { return displacement; } set { displacement = value; } }

        public string Efficiency { get { return efficiency; } set { efficiency = value; } }

        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model, string power, string displacement)
            :this(model,power)
        {
            Displacement = displacement;
        }
        public Engine(string model, string power, string displacement, string efficiency)
            :this(model,power,displacement)
        {
            Efficiency = efficiency;
        }
        */
        //---------------------------------------------------------------------------------------
        /*T03
        private int speed;
        private int power;

        public int Speed
        { get { return speed; } set { speed = value; } }
        public int Power
        { get { return power; } set { power = value;} }

        public Engine(string speed, string power)
        {
            Speed = int.Parse(speed);
            Power = int.Parse(power);
        }
        */


    }
}
