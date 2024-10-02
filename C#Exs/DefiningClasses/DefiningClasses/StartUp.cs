using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //T01
            /*
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(first,second);
            
            Console.WriteLine(dateModifier.ReturnDifferenceBetweenDates());
            */
            //--------------------------------------------------------------
            //T02
            /*
            HashSet<Car> cars = new HashSet<Car>();
            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string[] command = Console.ReadLine().Split();

                Car temp = new Car()
                {
                    Model = command[0],
                    FuelAmount = double.Parse(command[1]),
                    FuelConsumptionPerKilometer = double.Parse(command[2]),
                    TravelledDistance = 0
                };

                cars.Add(temp);
            }

            string input = string.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split();

                foreach (var car in cars)
                {
                    if (car.Model == command[1])
                    {
                        car.Drive(double.Parse(command[2]));
                        break;
                    }
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
            */
            //-------------------------------------------------------------------------------------
            //T03
            /*
            int loops = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();

            for (int i = 0; i < loops; i++)
            {
                string[] command = Console.ReadLine().Split();

                Car temp = new Car()
                {
                    Model = command[0],
                    CarEngine = new Engine(command[1], command[2]),
                    CarCargo = new Cargo(command[3], command[4]),
                    Tires = new List<Tire>()
                };
                for (int j = 5; j < 13; j += 2)
                {
                    temp.Tires.Add(new Tire(command[j], command[j + 1]));
                }

                cars.Add(temp);
            }


            string modifier = Console.ReadLine();
            if (modifier == "fragile")
            {
                cars = cars.Where(n => n.IsFragile()).ToHashSet();
            }
            else
            {
                cars = cars.Where(n => n.IsFlamable()).ToHashSet();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
            */
            //T04
            /*
            HashSet<Engine> engines = new HashSet<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine temp;
                switch (command.Length)
                {
                    case 3:
                        double displace;
                        bool isDisplaced = double.TryParse(command[2], out displace);
                        if (isDisplaced)
                        {
                            temp = new Engine(command[0], command[1], command[2]);
                        }
                        else
                        {
                            temp = new Engine(command[0], command[1], "n/a", command[2]);
                        }
                        break;
                    case 4:
                        temp = new Engine(command[0], command[1], command[2], command[3]);
                        break;
                    default:
                        temp = new Engine(command[0], command[1]);
                        break;
                }
                engines.Add(temp);
            }

            HashSet<Car> cars = new HashSet<Car>();
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine temp = new Engine(default, default);

                foreach (var engine in engines)
                {
                    if (engine.Model == command[1])
                    {
                        temp = engine;
                        break;
                    }
                }

                Car tempCar;
                switch (command.Length)
                {
                    case 3:
                        int weight;
                        bool isWeight = int.TryParse(command[2], out weight);
                        if (isWeight)
                        {
                            tempCar = new Car(command[0], temp, command[2]);
                        }
                        else
                        {
                            tempCar = new Car(command[0], temp, "n/a", command[2]);
                        }
                    
                        break;
                    
                    case 4:
                        
                        tempCar = new Car(command[0], temp, command[2], command[3]);

                        break;
            
                    default:

                        tempCar = new Car(command[0], temp);

                        break;
                }

                cars.Add(tempCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            */
            //--------------------------------------------------------------------------
            //T05
            
            List<Trainer> trainers = new List<Trainer>();

            string input = string.Empty;

            while (input != "Tournament")
            {
                input = Console.ReadLine();

                if (input == "Tournament")
                {
                    break;
                }

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                bool exists = false;
                Pokemon temp = new Pokemon(command[1], command[2], int.Parse(command[3]));
                foreach (var trainer in trainers)
                {
                    if (trainer.Name == command[0])
                    {
                        exists = true;
                        trainer.Pokemons.Add(temp);
                    }
                }
                if (!exists)
                {
                    Trainer tempTrainer = new Trainer(command[0], 0, new HashSet<Pokemon>());
                    tempTrainer.Pokemons.Add(temp);
                    trainers.Add(tempTrainer);
                }
            }

            while (input != "End")
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    trainer.CheckForElement(input);                
                }
            }

            foreach (var item in trainers.OrderByDescending(n => n.Badges))
            {
                Console.WriteLine(item);
            }
        }
    }
}
