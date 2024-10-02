using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Human> citizens = new List<Human>();
            List<Rebel> rebels = new List<Rebel>();

            int loops = int.Parse(Console.ReadLine());
            
            string input = string.Empty;

            for (int i = 0; i < loops; i++)
            {
                input = Console.ReadLine();

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command.Length)
                {
                    //0 - name, 1 - age, 2 - group
                    case 3:
                        Rebel rebel = new Rebel(command[0], int.Parse(command[1]), command[2]);
                        rebels.Add(rebel);
                        break;
                    //0 - name, 1 - age, 2 - id, 3 - birthdate
                    case 4:
                        Human human = new Human(command[0], int.Parse(command[1]), command[2], command[3]);
                        citizens.Add(human);
                        break;
                    default:
                        break;
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (rebels.Any(n => n.Name == input))
                {
                    rebels.Find(n => n.Name == input).BuyFood();
                }
                else if (citizens.Any(n => n.Name == input))
                {
                    citizens.Find(n => n.Name == input).BuyFood();
                }
                else
                {
                    continue;
                }
            }

            int food = 0;
            citizens.ForEach(n => food += n.Food);
            rebels.ForEach(n => food += n.Food);

            Console.WriteLine(food);
        }
    }
}
