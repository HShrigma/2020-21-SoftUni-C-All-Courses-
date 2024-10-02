using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public SkiRental(string name, int capacity)
        {
            data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; }
        public int Count => data.Count;

        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Ski ski = data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
            if (ski == null)
            {
                return false;
            }
            return true;
        }
        public Ski GetNewestSki() => data.OrderByDescending(s => s.Year).FirstOrDefault();

        public Ski GetSki(string manufacturer, string model) =>
            data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            data.ForEach(s => sb.AppendLine(s.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
