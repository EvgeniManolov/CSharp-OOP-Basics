using MordorsCrueltyPlan.FoodModels;
using MordorsCrueltyPlan.MoodModels;
using System.Collections.Generic;
using System.Linq;

namespace MordorsCrueltyPlan.Factories
{
    public static class MoodFactory
    {
        public static Mood CreateMood(List<Food> foods)
        {
            int indexOfHappines = foods.Sum(f => f.PointOfHappines);

            if (indexOfHappines < -5)
            {
                return new Angry();
            }
            else if (indexOfHappines >= -5 && indexOfHappines <= 0)
            {
                return new Sad();
            }
            else if (indexOfHappines >= 1 && indexOfHappines <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
