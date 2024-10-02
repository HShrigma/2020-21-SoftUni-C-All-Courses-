using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //T04
        /*
        private string model;
        private Engine engine;
        private string weight;
        private string color;
        public string Model { get { return model; } set {model = value;} }

        public Engine CarEngine { get { return engine; } set {engine = value;} }

        public string Weight { get { return weight;} set {weight = value;} }

        public string Color { get {return color;} set { color = value; } }

        public Car(string model, Engine engine)
        {
            Model = model;
            CarEngine = engine;
            Weight = "n/a";
            Color = "n/a";
        }
        public Car(string model, Engine engine, string weight)
            :this(model,engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string weight, string color)
            :this(model,engine,weight)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"{Model}:\n  {CarEngine.Model}:\n    Power: { CarEngine.Power}\n    Displacement: {CarEngine.Displacement}\n    Efficiency: { CarEngine.Efficiency}\n  Weight: {Weight}\n  Color: { Color}";
        }
        */
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        /*T03
        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }

        public List<Tire> Tires { get; set; }

        public bool IsFragile()
        {
            if (CarCargo.Type == "fragile")
            {
                foreach (var tire in Tires)
                {
                    if (tire.Pressure < 1)
                    {
                        return true;
                    }
                }
                return false;
            }

            return false;
        }

        public bool IsFlamable()
        {
            if (CarCargo.Type == "flamable" && CarEngine.Power > 250)
            {
                return true;
            }

            return false;
        }
        */
        //--------------------------------------------------------------
        /*T02
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public void Drive(double kilometers)
        {
            if (FuelConsumptionPerKilometer * kilometers <= FuelAmount)
            {
                FuelAmount -= FuelConsumptionPerKilometer * kilometers;
                TravelledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        */
    }
}
