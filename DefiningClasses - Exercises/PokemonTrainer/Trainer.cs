using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badgets;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.Badgets = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Badgets
        {
            get { return this.badgets; }
            set { this.badgets = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
    }
}
