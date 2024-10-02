using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                switch (type)
                {
                    case "Druid":
                        heroes.Add(new Druid(name));
                        n--;
                        break;
                    case "Paladin":
                        heroes.Add(new Paladin(name));
                        n--;
                        break;
                    case "Rogue":
                        heroes.Add(new Rogue(name));
                        n--;
                        break;
                    case "Warrior":
                        heroes.Add(new Warrior(name));
                        n--;
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var item in heroes)
            {
                Console.WriteLine(item.CastAbility());
                bossPower -= item.Power;
            }

            if (bossPower <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
