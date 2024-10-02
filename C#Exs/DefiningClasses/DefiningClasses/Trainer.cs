using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    class Trainer
    {
        private string name;
        private int badges;
        private HashSet<Pokemon> pokemons;

        public string Name { get { return name; } set { name = value; } }
        public int Badges { get { return badges; } set { badges = value; } }

        public HashSet<Pokemon> Pokemons { get { return pokemons; } set { pokemons = value; } }

        public Trainer(string name, int badges, HashSet<Pokemon> pokemons)
        {
            Name = name;
            Badges = badges;
            Pokemons = pokemons;
        }

        public void CheckForElement(string elementToCheck)
        {
            bool contains = false;
            foreach (var item in Pokemons)
            {
                if (item.Element == elementToCheck)
                {
                    contains = true;
                }
            }

            if (contains)
            {
                Badges++;
            }

            else
            {
                foreach (var pokemon in Pokemons)
                {
                    pokemon.HP -= 10;
                }
                Pokemons = RefreshPokemons();
            }
        }

        public HashSet<Pokemon> RefreshPokemons()
        {
            return Pokemons.Where(n => n.HP > 0).ToHashSet();
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
