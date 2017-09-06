using System;

namespace Vahicles
{
    public class Car : Vahicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get { return base.FuelConsumption; }
            set { base.FuelConsumption = value + 0.9; }
        }


        public override void Drive(double kilometers)
        {
            if (this.FuelQuantity >= kilometers * this.FuelConsumption)
            {
                this.FuelQuantity -= kilometers * this.FuelConsumption;
                Console.WriteLine($"Car travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }
        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }
    }
}
