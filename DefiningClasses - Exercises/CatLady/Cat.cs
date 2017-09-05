namespace CatLady
{
    public class Cat
    {
        private string breed;
        private string name;
        private double size;

        public Cat(string breed, string name, double size)
        {
            this.Breed = breed;
            this.Name = name;
            this.Size = size;
        }

        public string Breed
        {
            get { return this.breed; }
            private set { this.breed = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public double Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }
    }
}
