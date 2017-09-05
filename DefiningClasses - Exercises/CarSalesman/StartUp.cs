using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {

                string[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = tokens[0];
                string power = tokens[1];

                if (tokens.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (tokens.Length == 3)
                {
                    int diplacement;
                    bool isDiplacement = int.TryParse(tokens[2], out diplacement);
                    if (isDiplacement)
                    {
                        engines.Add(new Engine(model, power, diplacement));
                    }
                    else
                    {
                        string efficiency = tokens[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (tokens.Length == 4)
                {
                    int diplacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];
                    engines.Add(new Engine(model, power, diplacement, efficiency));
                }
            }

            int numbersOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numbersOfCars; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = tokens[0];
                string engineModel = tokens[1];
                Engine engine = new Engine(null, null);

                foreach (Engine eng in engines)
                {
                    if (eng.Model == engineModel)
                    {
                        engine = eng;
                    }
                }

                if (tokens.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                else if (tokens.Length == 3)
                {
                    int weight;
                    bool isWeight = int.TryParse(tokens[2], out weight);

                    if (isWeight)
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = tokens[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                else if (tokens.Length == 4)
                {
                    int weight = int.Parse(tokens[2]);
                    string color = tokens[3];
                    cars.Add(new Car(model, engine, weight, color));
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.model}:");
                Console.WriteLine($"  {car.engine.Model}:");
                Console.WriteLine($"    Power: {car.engine.Power}");

                if (car.engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.engine.Displacement}");
                }

                Console.WriteLine($"    Efficiency: {car.engine.Efficiency}");

                if (car.weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.weight}");
                }

                //---other option to print Weight----//
                //Console.WriteLine($"  Weight: {0}", car.weight == 0 ? "n/a" : car.weight.ToString());
                Console.WriteLine($"  Color: {car.color}");
            }
        }
    }
}
