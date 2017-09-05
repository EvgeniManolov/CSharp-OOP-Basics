using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionPerKilometer));
            }


            string infoLine;

            while ((infoLine = Console.ReadLine()) != "End")
            {
                string[] tokens = infoLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = tokens[1];
                double amountOfKilometer = double.Parse(tokens[2]);

                Car currentCar = cars[cars.FindIndex(car => car.Model == model)];
                Car.calculateDistance(currentCar, amountOfKilometer);

            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.Distance}");
            }
        }
    }
}
