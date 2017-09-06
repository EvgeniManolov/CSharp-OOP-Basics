using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MordorsCrueltyPlan.FoodModels;
using MordorsCrueltyPlan.MoodModels;
using MordorsCrueltyPlan.Factories;

namespace MordorsCrueltyPlan
{
    public class StartUp
    {
        public static void Main()
        {
            List<Food> foods = new List<Food>();

            string[] foodTokens = Regex.Split(Console.ReadLine(), @"\s+");

            foreach (string foodToken in foodTokens)
            {
                Food currentFood = FoodFactory.CreateFood(foodToken);
                foods.Add(currentFood);
            }

            Mood mood = MoodFactory.CreateMood(foods);

            Console.WriteLine(foods.Sum(f => f.PointOfHappines));
            Console.WriteLine(mood);
        }
    }
}
