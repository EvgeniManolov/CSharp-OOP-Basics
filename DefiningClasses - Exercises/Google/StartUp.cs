using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string personName = tokens[0];

                if (!people.Any(p => p.Name == personName))
                {
                    people.Add(new Person(personName));
                }

                string action = tokens[1];
                Person person = people.Where(p => p.Name == personName).First();

                switch (action)
                {
                    case "company":
                        string companyName = tokens[2];
                        string department = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);
                        person.Company = new Company(companyName, department, salary);
                        break;
                    case "pokemon":
                        string pokemonName = tokens[2];
                        string pokemonType = tokens[3];
                        person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        break;
                    case "parents":
                        string parentName = tokens[2];
                        string parentBirthday = tokens[3];
                        person.Parents.Add(new Parent(parentName, parentBirthday));
                        break;
                    case "children":
                        string childName = tokens[2];
                        string childBirthday = tokens[3];
                        person.Children.Add(new Child(childName, childBirthday));
                        break;
                    case "car":
                        string model = tokens[2];
                        double speed = double.Parse(tokens[3]);
                        person.Car = new Car(model, speed);
                        break;
                }
                input = Console.ReadLine();
            }

            string searchPerson = Console.ReadLine();

            Person currentPerson = people.Where(p => p.Name == searchPerson).First();

            Console.WriteLine(currentPerson.Name);
            Console.WriteLine("Company:");
            if (currentPerson.Company != null)
            {
                Console.WriteLine(currentPerson.Company);
            }

            Console.WriteLine("Car:");
            if (currentPerson.Car != null)
            {
                Console.WriteLine(currentPerson.Car);
            }

            Console.WriteLine("Pokemon:");
            currentPerson.Pokemons.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Parents:");
            currentPerson.Parents.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Children:");
            currentPerson.Children.ForEach(c => Console.WriteLine(c));
        }
    }
}
