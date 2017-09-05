using System;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuel;
        private double fuelConsumption;
        private double distance;

        public Car(string model, double fuel, double fuelConsumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public double Fuel
        {
            get { return this.fuel; }
            private set { this.fuel = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            private set { this.fuelConsumption = value; }
        }

        public double Distance
        {
            get { return this.distance; }
            private set { this.distance = value; }
        }
        public static void calculateDistance(Car car, double distance)
        {
            double travelKilometers = car.Fuel / car.FuelConsumption;


            if (travelKilometers < distance)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.Fuel -= distance * car.FuelConsumption;
                car.Distance += distance;
            }
        }
    }
}
