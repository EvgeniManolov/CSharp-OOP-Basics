using System;

namespace Vahicles
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));

            string[] truckArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(carArgs[3]));

            string[] busArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Bus bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArgs[0];
                string vehicle = cmdArgs[1];
                double numberArg = double.Parse(cmdArgs[2]);

                switch (cmd)
                {
                    case "Drive":
                        switch (vehicle)
                        {
                            case "Car":
                                car.Drive(numberArg);
                                break;
                            case "Truck":
                                truck.Drive(numberArg);
                                break;
                            case "Bus":
                                bus.Drive(numberArg);
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        bus.DriveEmp(numberArg);
                        break;
                    case "Refuel":
                        switch (vehicle)
                        {
                            case "Car":
                                car.Refuel(numberArg);
                                break;
                            case "Truck":
                                truck.Refuel(numberArg);
                                break;
                            case "Bus":
                                bus.Refuel(numberArg);
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
