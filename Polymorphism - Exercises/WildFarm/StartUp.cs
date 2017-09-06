using System;
using WildFarm.Models;
using WildFarm.Models.Animals;
using WildFarm.Models.Factory;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalTokens = input.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string[] foodTokens = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.GetAnimal(animalTokens);
                Food food = FoodFactory.GetFood(foodTokens);

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal);
            }
        }
    }
}
