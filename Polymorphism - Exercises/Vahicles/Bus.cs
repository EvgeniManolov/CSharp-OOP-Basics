using System;

namespace Vahicles
{
    public class Bus : Vahicle
    {
        public const double AddFuel = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get { return base.FuelConsumption; }
            set { base.FuelConsumption = value; }
        }

        public override void Drive(double kilometers)
        {
            if (this.FuelQuantity - (kilometers * (this.FuelConsumption + AddFuel)) > 0)
            {
                this.FuelQuantity -= kilometers * (this.FuelConsumption + 1.40);
                Console.WriteLine($"Bus travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public void DriveEmp(double kilometers)
        {
            if (this.FuelQuantity >= kilometers * this.FuelConsumption)
            {
                this.FuelQuantity -= kilometers * (this.FuelConsumption);
                Console.WriteLine($"Bus travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double liters)
        {

            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }

            this.FuelQuantity += liters;
        }
        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:f2}";
        }
    }
}
