using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];

            for (int i = 0; i < numberOfCars; i++)
            {
                string input = Console.ReadLine();
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = tokens[0];
                int speed = int.Parse(tokens[1]);
                int power = int.Parse(tokens[2]);
                int weight = int.Parse(tokens[3]);
                string type = tokens[4];
                double firstTypePressure = double.Parse(tokens[5]);
                int firstTypeAge = int.Parse(tokens[6]);
                double secondTypePressure = double.Parse(tokens[7]);
                int secondTypeAge = int.Parse(tokens[8]);
                double thirdTypePressure = double.Parse(tokens[9]);
                int thirdTypeAge = int.Parse(tokens[10]);
                double fourthTypePressure = double.Parse(tokens[11]);
                int fourthTypeAge = int.Parse(tokens[12]);

                cars[i] = new Car(model,
                    new Engine(speed, power),
                    new Cargo(weight, type),
                    new List<Tyre> { new Tyre(firstTypePressure, firstTypeAge), new Tyre(secondTypePressure, secondTypeAge), new Tyre(thirdTypePressure, thirdTypeAge), new Tyre(fourthTypePressure, fourthTypeAge) });
            }

            string command;

            if ((command = Console.ReadLine()) == "fragile")
            {
                cars.Where(x => x.Cargo.Type == "fragile")
                    .Where(x => x.Tyres.Any(p => p.Pressure < 1))
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else
            {
                cars.Where(x => x.Cargo.Type == "flamable")
                    .Where(x => x.Engine.Power > 250)
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
