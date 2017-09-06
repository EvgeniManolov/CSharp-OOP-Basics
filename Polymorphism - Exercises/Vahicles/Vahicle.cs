using System;

namespace Vahicles
{
    public abstract class Vahicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vahicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public virtual double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public virtual double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public virtual double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public abstract void Refuel(double liters);
        public abstract void Drive(double kilometers);
    }
}
