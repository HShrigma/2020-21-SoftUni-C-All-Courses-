using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        private string manufacturer;
        private string model;
        private int year;

        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Model { get { return model; } set { model = value; } }

        public int Year { get { return year; } set { year = value; } }

        public Ski(string manufacturer, string model, int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            if (year > 0 && year <= 2021)
            {
                this.Year = year;
            }

        }

        /// <summary>
        /// Returns Ski data in this format: manufacturer  - model - year
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.manufacturer} - {this.model} - {this.year}";
        }
    }
}
