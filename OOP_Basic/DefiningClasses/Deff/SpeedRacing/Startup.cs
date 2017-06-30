namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<string, Car> mapModelCar = new Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string carModel = tokens[0];
                decimal fuelAmount = decimal.Parse(tokens[1]);
                decimal priceFor1Km = decimal.Parse(tokens[2]);

                Car currCar = new Car(carModel, fuelAmount, priceFor1Km);
                
                mapModelCar.Add(carModel, currCar);
                
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] args = input.Split(' ');

                string model = args[1];
                double distanceToTravel = double.Parse(args[2]);
                mapModelCar[model].calcIfPossible(distanceToTravel);
            }

            foreach (var pair in mapModelCar)
            {
                Console.WriteLine($"{pair.Key} {pair.Value.FuelAmount:f2} {pair.Value.DistancedTraveled}");
            }
        }
    }
}
