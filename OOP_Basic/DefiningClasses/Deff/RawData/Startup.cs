namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            IList<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split(' ');
                string model = args[0];
                int engineSpeed = int.Parse(args[1]);
                int enginePower = int.Parse(args[2]);
                int cargoWeight = int.Parse(args[3]);
                string cargoType = args[4];

                double tirePressure1 = double.Parse(args[5]);
                int tireAge1 = int.Parse(args[6]);
                double tirePressure2 = double.Parse(args[7]);
                int tireAge2 = int.Parse(args[8]);
                double tirePressure3 = double.Parse(args[9]);
                int tireAge3 = int.Parse(args[10]);
                double tirePressure4 = double.Parse(args[11]);
                int tireAge4 = int.Parse(args[12]);

                Car currCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
             tireAge1, tirePressure1,
             tireAge2, tirePressure2,
             tireAge3, tirePressure3,
             tireAge4, tirePressure4);

                cars.Add(currCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars
                    .Where(c => c.Cargo.Type == "fragile"
                    && c.Tire.Sum(t => t.TirePressure) < 4)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
            else
            {
                cars
                    .Where(c => c.Engine.Power > 250 && c.Cargo.Type == "flamable")
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
