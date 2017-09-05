using System.Collections.Generic;

namespace Google
{
    class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;

        public Person(string name)
        {
            this.Name = name;
            this.Car = null;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            private set { this.pokemons = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            private set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            private set { this.children = value; }
        }
    }
}
