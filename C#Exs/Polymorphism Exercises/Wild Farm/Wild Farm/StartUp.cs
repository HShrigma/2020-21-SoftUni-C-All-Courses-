using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            int loopCount = default;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (loopCount % 2 == 0)
                {
                    switch (command[0])
                    {
                        //Birds - "{Type} {Name} {Weight} {WingSize}";
                        case "Hen":
                            animals.Add(new Hen(command[1], double.Parse(command[2]), double.Parse(command[3])));
                            break;
                        case "Owl":
                            animals.Add(new Owl(command[1], double.Parse(command[2]), double.Parse(command[3])));
                            break;
                        //Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";
                        case "Mouse":
                            animals.Add(new Mouse(command[1], double.Parse(command[2]), command[3]));
                            break;
                        case "Dog":
                            animals.Add(new Dog(command[1], double.Parse(command[2]), command[3]));
                            break;
                        //Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
                        case "Cat":
                            animals.Add(new Cat(command[1], double.Parse(command[2]), command[3], command[4]));
                            break;
                        case "Tiger":
                            animals.Add(new Tiger(command[1], double.Parse(command[2]), command[3], command[4]));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Food food = new Vegetable(default);
                    switch (command[0])
                    {
                        case "Fruit":
                            food = new Fruit(int.Parse(command[1]));
                            break;
                        case "Vegetable":
                            food = new Vegetable(int.Parse(command[1]));
                            break;
                        case "Meat":
                            food = new Meat(int.Parse(command[1]));
                            break;
                        case "Seeds":
                            food = new Seeds(int.Parse(command[1]));
                            break;
                    }

                    animals.Last().Eat(food);
                }
                loopCount++;
            }

            animals.ForEach(n => Console.WriteLine(n));
        }
    }
}
