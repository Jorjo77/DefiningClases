
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                var splittedCommand = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = splittedCommand[0];
                string pokemonName = splittedCommand[1];
                string element = splittedCommand[2];
                int health = int.Parse(splittedCommand[3]);
                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                if (trainer != null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                    trainers.Add(newTrainer);
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (!trainers[i].Pokemons.Any(x => x.Element == command))
                    {
                        foreach (var pokemon in trainers[i].Pokemons)
                        {
                            pokemon.ReduceHealth();
                        }
                    }
                    else
                    {
                        trainers[i].IncreaceNumberOfBadges();
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var pokemon in trainers)
            {
                pokemon.Pokemons.RemoveAll(x => x.Health <= 0);
            }
            trainers.OrderByDescending(x => x.NumberOfBadges).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.NumberOfBadges} {x.Pokemons.Count}"));
        }
    }
}
