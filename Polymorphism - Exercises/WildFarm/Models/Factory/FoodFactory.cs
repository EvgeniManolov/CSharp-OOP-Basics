using WildFarm.Models.Foods;

namespace WildFarm.Models.Factory
{
    public class FoodFactory
    {
        public static Food GetFood(string[] tokens)
        {
            string foodType = tokens[0];
            int foodQuantity = int.Parse(tokens[1]);

            if (foodType == "Meat")
            {
                return new Meat(foodQuantity);
            }
            return new Vegetable(foodQuantity);
        }
    }
}
