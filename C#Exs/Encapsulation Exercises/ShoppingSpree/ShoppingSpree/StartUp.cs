using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new List<Person>();

                string[] peopleStats = ReadStrArray(';');

                foreach (var stat in peopleStats)
                {
                    string[] info = stat.Split('=', StringSplitOptions.RemoveEmptyEntries);

                    Person temp = new Person(info[0], double.Parse(info[1]));

                    people.Add(temp);
                }

                List<Product> products = new List<Product>();
                string[] productsStats = ReadStrArray(';');

                foreach (var stat in productsStats)
                {
                    string[] info = stat.Split('=', StringSplitOptions.RemoveEmptyEntries);

                    Product temp = new Product(info[0], double.Parse(info[1]));
                    products.Add(temp);
                }

                string[] command = new string[2] { string.Empty, string.Empty };

                while (command[0] != "END")
                {
                    command = ReadStrArray(' ');

                    switch (command[0])
                    {
                        case "END":
                            break;
                        default:
                            if (people.Where(n => n.Name == command[0]).Any() && products.Where(n => n.Name == command[1]).Any())
                            {
                                people.Find(n => n.Name == command[0]).Buy(products.Find(n => n.Name == command[1]));
                            }
                            break;
                    }
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        static string[] ReadStrArray(char separator)
        {
            return Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
