namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {
        public Animal(string name, string type, double weight)
        {
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
        }
        protected string Name { get; private set; }
        protected string Type { get; private set; }
        protected double Weight { get; private set; }
        protected int FoodEaten { get; private set; }

        public abstract string MakeSound();

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
    }
}
