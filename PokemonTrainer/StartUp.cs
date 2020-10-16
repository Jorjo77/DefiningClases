using System;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {

                string inputData = Console.ReadLine();
                if (inputData== "Tournament")
                {
                    break;
                }
                string[] splittedInputData = inputData.Split();
                string trainerName = splittedInputData[0];
                string pokemonName = splittedInputData[1];
                string pokemonElement = splittedInputData[2];
                int pokemonHealth = int.Parse(splittedInputData[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = new Trainer(trainerName, 0, pokemon);

                if (!trainers.Contains(trainer))
                {
                    trainers.Add(trainer);
                }

            }
        }
    }
}
