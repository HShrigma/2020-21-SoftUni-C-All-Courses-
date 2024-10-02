using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Pokemon
    {
        private string name;
        private string element;
        private int hp;

        public string Name { get { return name; } set { name = value; } }
        public string Element { get { return element; } set { element = value; } }

        public int HP { get { return hp; } set { hp = value; } }

        public Pokemon(string name, string element, int hp)
        {
            Name = name;
            Element = element;
            HP = hp;
        }
    }
}
