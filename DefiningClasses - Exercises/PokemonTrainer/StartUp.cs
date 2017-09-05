using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (command != "Tournament")
            {
                string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string element = tokens[2];
                int health = int.Parse(tokens[3]);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                Trainer trainer = trainers.First(t => t.Name == trainerName);
                trainer.Pokemons.Add(new Pokemon(pokemonName, element, health));

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.Badgets++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                    }
                }
                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badgets))
            {
                Console.WriteLine("{0} {1} {2}", trainer.Name, trainer.Badgets, trainer.Pokemons.Count);
            }
        }
    }
}
