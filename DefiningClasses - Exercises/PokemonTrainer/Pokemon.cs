namespace PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private double health;

        public Pokemon(string name, string element, double health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Element
        {
            get { return this.element; }
            private set { this.element = value; }
        }

        public double Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}
