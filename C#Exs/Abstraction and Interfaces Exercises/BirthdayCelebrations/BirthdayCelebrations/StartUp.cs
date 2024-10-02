using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string[]> birthdays = new List<string[]>();
            List<Entity> entities = new List<Entity>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Entity temp = null;

                switch (command[0])
                {
                    //0 - "Robot", 1 - name, 2 - id
                    case "Robot":
                        temp = new Robot(command[1], command[2]);
                        break;
                    //0 - "Citizen", 1 - name, 2 - age, 3 - id, 4 - birthday
                    case "Citizen":
                        temp = new Human(command[1], int.Parse(command[2]), command[3], command[4]);
                        birthdays.Add(temp.Birthday);
                        break;
                    //0 - "Pet", 1 - name, 2 - birthday
                    case "Pet":
                        temp = new Pet(command[1], command[2]);
                        birthdays.Add(temp.Birthday);
                        break;
                    default:
                        break;
                }
                entities.Add(temp);
            }

            string pickedYear = Console.ReadLine();

            if (birthdays.Any(n => n[2] == pickedYear))
            {
                List<string[]> selectedBirthdays = birthdays.Where(n => n[2] == pickedYear).ToList(); 
                selectedBirthdays.ForEach(n => Console.WriteLine(string.Join('/', n)));
            }
        }
    }
}
