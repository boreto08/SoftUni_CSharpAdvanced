using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class Startup
    {
       static Dictionary<string, AirBender> mapNameAirBender = new Dictionary<string, AirBender>();
       static Dictionary<string, WaterBender> mapNameWaterBender = new Dictionary<string, WaterBender>();
       static Dictionary<string, FireBender> mapNameFireBender = new Dictionary<string, FireBender>();
       static Dictionary<string, EarthBender> mapNameEarthBender = new Dictionary<string, EarthBender>();

       static Dictionary<string, AirMonument> mapNameAirMonument = new Dictionary<string, AirMonument>();
       static Dictionary<string, WaterMonument> mapNameWaterMonument = new Dictionary<string, WaterMonument>();
       static Dictionary<string, FireMonument> mapNameFireMonument = new Dictionary<string, FireMonument>();
       static Dictionary<string, EarthMonument> mapNameEarthMonument = new Dictionary<string, EarthMonument>();
       
        static void Main()
        {
            List<string> listOfWars = new List<string>();
            int countWars = 1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                switch (command)
                {
                    case "Bender":
                        RegisterBender(tokens);
                        break;
                    case "Monument":
                        RegisteMoument(tokens);
                        break;
                    case "War":
                        string name = tokens[1];
                        CalcWinner();
                        listOfWars.Add(string.Format($"War {countWars} issued by {name}"));
                        countWars++;
                        break;
                    case "Status":
                        string nameOfNation = tokens[1];
                        PrintStatus(nameOfNation);
                        break;
                    
                }
            }

            foreach (var war in listOfWars)
            {
                Console.WriteLine(war);
            }

        }

        private static void PrintStatus(string nameOfNation)
        {
            switch (nameOfNation)
            {
                case "Air":
                    PrintAirNation();
                    break;
                case "Fire":
                    PrintFireNation();
                    break;
                case "Water":
                    PrintWaterNation();
                    break;
                case "Earth":
                    PrintEarthNation();
                    break;

            }
        }

        private static void PrintEarthNation()
        {
            Console.WriteLine("Earth Nation");
            Console.Write("Benders:");
            if (mapNameEarthBender.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var bender in mapNameEarthBender.Values)
                {
                    Console.WriteLine($"###Earth Bender: {bender.Name}, Power: {bender.Power}, Ground Saturation: {bender.GroundSaturation:f2}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }
            Console.Write("Monuments:");
            if (mapNameEarthMonument.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var monument in mapNameEarthMonument.Values)
                {
                    Console.WriteLine($"###Earth Monument: {monument.Name}, Earth Affinity: {monument.EarthAffinity}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }

        }

        private static void PrintWaterNation()
        {
            Console.WriteLine("Water Nation");
            Console.Write("Benders:");
            if (mapNameWaterBender.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var bender in mapNameWaterBender.Values)
                {
                    Console.WriteLine($"###Water Bender: {bender.Name}, Power: {bender.Power}, Water Clarity: {bender.WaterClarity:f2}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }
            Console.Write("Monuments:");
            if (mapNameWaterMonument.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var monument in mapNameWaterMonument.Values)
                {
                    Console.WriteLine($"###Water Monument: {monument.Name}, Water Affinity: {monument.WaterAffinity}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }

        }

        private static void PrintFireNation()
        {
            Console.WriteLine("Fire Nation");
            Console.Write("Benders:");
            if (mapNameFireBender.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var bender in mapNameFireBender.Values)
                {
                    Console.WriteLine($"###Fire Bender: {bender.Name}, Power: {bender.Power}, Heat Aggression: {bender.HeatAggression:f2}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }
            Console.Write("Monuments:");
            if (mapNameFireMonument.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var monument in mapNameFireMonument.Values)
                {
                    Console.WriteLine($"###Fire Monument: {monument.Name}, Fire Affinity: {monument.FireAffinity}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }

        }

        private static void PrintAirNation()
        {
            Console.WriteLine("Air Nation");
            Console.Write("Benders:");
            if (mapNameAirBender.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var bender in mapNameAirBender.Values)
                {
                    Console.WriteLine($"###Air Bender: {bender.Name}, Power: {bender.Power}, Aerial Integrity: {bender.AerialIntegirty:f2}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }
            Console.Write("Monuments:");
            if (mapNameAirMonument.Values.Count > 0)
            {
                Console.WriteLine();
                foreach (var monument in mapNameAirMonument.Values)
                {
                    Console.WriteLine($"###Air Monument: {monument.Name}, Air Affinity: {monument.AirAffinity}");
                }
            }
            else
            {
                Console.WriteLine(" None");
            }
            
            
        }

        private static void CalcWinner()
        {
            double fireNationScore = CalcFireNationScore();
            double airNationScore = CalcAirNationScore();
            double earthNationScore = CalcEarthNationScore();
            double waterNationScore = CalcWaterNationScore();
            ClearLosers(fireNationScore, airNationScore, earthNationScore, waterNationScore);
        }

        private static void ClearLosers(double fireNationScore, double airNationScore,
            double earthNationScore, double waterNationScore)
        {
            if (fireNationScore > airNationScore
                            && fireNationScore > earthNationScore
                            && fireNationScore > waterNationScore)
            {
                mapNameAirBender.Clear();
                mapNameAirMonument.Clear();

                mapNameEarthBender.Clear();
                mapNameEarthMonument.Clear();

                mapNameWaterBender.Clear();
                mapNameWaterMonument.Clear();
            }

            if (airNationScore > fireNationScore
                            && airNationScore > earthNationScore
                            && airNationScore > waterNationScore)
            {
                mapNameFireBender.Clear();
                mapNameFireMonument.Clear();

                mapNameEarthBender.Clear();
                mapNameEarthMonument.Clear();

                mapNameWaterBender.Clear();
                mapNameWaterMonument.Clear();
            }

            if (earthNationScore > fireNationScore
                            && earthNationScore > airNationScore
                            && earthNationScore > waterNationScore)
            {
                mapNameFireBender.Clear();
                mapNameFireMonument.Clear();

                mapNameAirBender.Clear();
                mapNameAirMonument.Clear();

                mapNameWaterBender.Clear();
                mapNameWaterMonument.Clear();
            }

            if (waterNationScore > fireNationScore
                            && waterNationScore > airNationScore
                            && waterNationScore > earthNationScore)
            {
                mapNameFireBender.Clear();
                mapNameFireMonument.Clear();

                mapNameAirBender.Clear();
                mapNameAirMonument.Clear();

                mapNameEarthBender.Clear();
                mapNameEarthMonument.Clear();
            }
        }

        private static double CalcWaterNationScore()
        {
            double bendersScore = 0.0;

            foreach (var bender in mapNameWaterBender.Values)
            {
                bendersScore += bender.Power * bender.WaterClarity;
            }

            double monumentsScore = mapNameWaterMonument.Values.Sum(m => m.WaterAffinity);

            monumentsScore = (bendersScore / 100.0) * monumentsScore;
            double totalResult = bendersScore + monumentsScore;

            return totalResult;
        }

        private static double CalcEarthNationScore()
        {
            double bendersScore = 0.0;

            foreach (var bender in mapNameEarthBender.Values)
            {
                bendersScore += bender.Power * bender.GroundSaturation;
            }

            double monumentsScore = mapNameEarthMonument.Values.Sum(m => m.EarthAffinity);

            monumentsScore = (bendersScore / 100.0) * monumentsScore;
            double totalResult = bendersScore + monumentsScore;

            return totalResult;
        }

        private static double CalcAirNationScore()
        {
            double bendersScore = 0.0;

            foreach (var bender in mapNameAirBender.Values)
            {
                bendersScore += bender.Power * bender.AerialIntegirty;
            }

            double monumentsScore = mapNameAirMonument.Values.Sum(m => m.AirAffinity);
            monumentsScore = (bendersScore / 100.0) * monumentsScore;
            double totalResult = bendersScore + monumentsScore;
            return totalResult;
        }

        private static double CalcFireNationScore()
        {
            double bendersScore = 0.0;

            foreach (var bender in mapNameFireBender.Values)
            {
                bendersScore += bender.Power * bender.HeatAggression;
            }

            double monumentsScore = mapNameFireMonument.Values.Sum(m => m.FireAffinity);
            monumentsScore = (bendersScore / 100.0) * monumentsScore;
            double totalResult = bendersScore + monumentsScore;
            return totalResult;
        }

        private static void RegisteMoument(string[] tokens)
        {
            string type = tokens[1];
            string name = tokens[2];
            int power = int.Parse(tokens[3]);
            

            switch (type)
            {
                case "Fire":
                    FireMonument fireMonument = new FireMonument(name, power);
                    mapNameFireMonument.Add(name, fireMonument);
                    break;
                case "Air":
                    AirMonument airMonument = new AirMonument(name, power);
                    mapNameAirMonument.Add(name, airMonument);
                    break;
                case "Water":
                    WaterMonument waterMonument = new WaterMonument(name, power);
                    mapNameWaterMonument.Add(name, waterMonument);
                    break;
                case "Earth":
                    EarthMonument earthMonument = new EarthMonument(name, power);
                    mapNameEarthMonument.Add(name, earthMonument);
                    break;
            }
        }

        private static void RegisterBender(string[] tokens)
        {
            string type = tokens[1];
            string name = tokens[2];
            int power = int.Parse(tokens[3]);
            double secParameter = double.Parse(tokens[4]);
            
            switch (type)
            {
                case "Fire":
                   FireBender fireBender = new FireBender(name, power, secParameter);
                    mapNameFireBender.Add(name, fireBender);
                    break;
                case "Air":
                    AirBender airBender = new AirBender(name, power, secParameter);
                    mapNameAirBender.Add(name, airBender);
                    break;
                case "Water":
                    WaterBender waterBender = new WaterBender(name, power, secParameter);
                    mapNameWaterBender.Add(name, waterBender);
                    break;
                case "Earth":
                    EarthBender earthBender = new EarthBender(name, power, secParameter);
                    mapNameEarthBender.Add(name, earthBender);
                    break;
            }

        }
    }
}
