using System;

namespace AnimalFarm
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.GetProductPerDay()} eggs per day.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
