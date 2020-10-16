using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {

        List<Pokemon> pokemons;
        public Trainer(string name, int badgesNumber, Pokemon pokemon)
        {
            Name = name;
            BadgesNumber = badgesNumber;
            this.pokemons = new List<Pokemon>();
            pokemons.Add(pokemon);
        }


        public string Name { get; set; }
        public int BadgesNumber { get; set; }
    }
}
