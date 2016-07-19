namespace _05.Speed_Racing
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class SpeedRacing
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                cars[input[0]] = new Car(double.Parse(input[1]), double.Parse(input[2]));
            }

            var drive = Console.ReadLine();
            while (drive != "End")
            {
                var arguments = drive.Split();
                var car = cars[arguments[1]];
                var driveFuel = car.Drive(car.FuelCostPerKm, long.Parse(arguments[2]));

                if (car.FuelAmount - driveFuel < 0)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    car.FuelAmount -= driveFuel;
                    car.DistanceTraveled += long.Parse(arguments[2]);
                }

                drive = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.Key, car.Value.FuelAmount, car.Value.DistanceTraveled);
            }
        }
    }

    public class Car
    {
        public Car(double fuelAmount, double fuelCostPerKm, long distanceTraveled = 0)
        {
            this.FuelAmount = fuelAmount;
            this.FuelCostPerKm = fuelCostPerKm;
            this.DistanceTraveled = distanceTraveled;
        }

        public long DistanceTraveled { get; set; }

        public double FuelAmount { get; set; }

        public double FuelCostPerKm { get; set; }

        public double Drive(double fuelPerKm, long distance)
        {
            return fuelPerKm * distance;
        }
    }
}