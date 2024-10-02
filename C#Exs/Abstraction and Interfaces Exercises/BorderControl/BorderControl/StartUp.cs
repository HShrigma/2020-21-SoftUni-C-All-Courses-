using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> detained = new List<string>();
            List<Entity> entities = new List<Entity>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Entity temp = null;

                switch (command.Length)
                {
                    //robot: 0 - model, 1 - ID
                    case 2:
                        temp = new Robot(command[0], command[1]);
                        break;
                    //human: 0 - name, 2 - age, 3 - ID
                    case 3:
                        temp = new Human(command[0], int.Parse(command[1]), command[2]);
                        break;
                    default:
                        break;
                }

                entities.Add(temp);
            }

            string fake = Console.ReadLine();

            if (entities.Any(n => n.Id.EndsWith(fake)))
            {
                foreach (var item in entities.Where(n => n.Id.EndsWith(fake)))
                {
                    Console.WriteLine(item.Id);
                }
            }

        }
    }
}
