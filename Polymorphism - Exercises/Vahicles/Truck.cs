using System;

namespace Vahicles
{
    class Truck : Vahicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get { return base.FuelConsumption; }
            set { base.FuelConsumption = value + 1.6; }
        }

        public override void Drive(double kilometers)
        {
            if (this.FuelQuantity >= this.FuelConsumption * kilometers)
            {
                this.FuelQuantity -= this.FuelConsumption * kilometers;
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.FuelQuantity += liters * 0.95;
            }
        }
        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
