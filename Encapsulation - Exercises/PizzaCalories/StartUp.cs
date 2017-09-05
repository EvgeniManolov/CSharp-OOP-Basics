using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main()
        {
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] tokens = command.Split();

                    switch (tokens[0])
                    {
                        case "Dough": PrintDoughData(tokens); break;
                        case "Topping": PrintToppingData(tokens); break;
                        case "Pizza": PrintPizzaData(tokens); break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }

        private static void PrintPizzaData(string[] tokens)
        {
            Pizza pizza = new Pizza(tokens[1], int.Parse(tokens[2]));

            tokens = Console.ReadLine().Split();
            Dough dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
            pizza.Dough = dough;

            for (int i = 0; i < pizza.ToppingsCount; i++)
            {
                tokens = Console.ReadLine().Split();
                Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));
                pizza.AddToppingsToPizza(topping);
            }

            Console.WriteLine(pizza.ToString());
        }

        private static void PrintToppingData(string[] tokens)
        {
            Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));
            Console.WriteLine($"{topping.GetToppingCalories():f2}");
        }

        private static void PrintDoughData(string[] tokens)
        {
            Dough dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
            Console.WriteLine($"{dough.GetDoughCalories():f2}");
        }
    }
}