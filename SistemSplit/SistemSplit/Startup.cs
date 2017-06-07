using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemSplit
{
    class Startup
    {

        static void Main()
        {
            Dictionary<string, Hardware> mapNameHardware = new Dictionary<string, Hardware>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "System Split")
                {
                    SistemSplitCommand(mapNameHardware);
                    break;
                }

                string[] tokens = input.Split('(');
                string command = tokens[0];

                switch (command)
                {
                    case "RegisterPowerHardware":
                        RegisterPowerHardware(mapNameHardware,tokens[1]);
                        break;
                    case "RegisterHeavyHardware":
                        RegisterHeavyHardware(mapNameHardware, tokens[1]);
                        break;
                    case "RegisterExpressSoftware":
                        RegisterExpressSoftware(mapNameHardware,tokens[1]);
                        break;
                    case "RegisterLightSoftware":
                        RegisterLightSoftware(mapNameHardware, tokens[1]);
                        break;
                    case "ReleaseSoftwareComponent":
                        ReleaseSoftwareComponent(mapNameHardware, tokens[1]);
                        break;
                    case "Analyze":
                        Analyze(mapNameHardware);
                        break;

                }
            }



        }

        private static void SistemSplitCommand(Dictionary<string, Hardware> mapNameHardware)
        {
            foreach (var hardware in mapNameHardware.Values)
            {
                if (hardware.Type == "Power")
                {
                    Console.WriteLine($"Hardware Component – {hardware.Name}");
                    Console.WriteLine($"Express Software Components: {hardware.countExpessSoftware()}");
                    Console.WriteLine($"Light Software Components: {hardware.countLightSoftware()}");
                    Console.WriteLine($"Memory Usage: {hardware.memoryInUse()} / {hardware.MaxMemory}");
                    Console.WriteLine($"Capacity Usage: {hardware.capacityInUse()} / {hardware.MaxCapacity}");
                    Console.WriteLine($"Type: {hardware.Type}");
                    Console.WriteLine("Software Components: {0}",
                        hardware.softwareNames().Count > 0 ? string.Join(", ", hardware.softwareNames()) : "None");
                }
                
            }
            foreach (var hardware in mapNameHardware.Values)
            {
                if (hardware.Type == "Heavy")
                {
                    Console.WriteLine($"Hardware Component – {hardware.Name}");
                    Console.WriteLine($"Express Software Components: {hardware.countExpessSoftware()}");
                    Console.WriteLine($"Light Software Components: {hardware.countLightSoftware()}");
                    Console.WriteLine($"Memory Usage: {hardware.memoryInUse()} / {hardware.MaxMemory}");
                    Console.WriteLine($"Capacity Usage: {hardware.capacityInUse()} / {hardware.MaxCapacity}");
                    Console.WriteLine($"Type: {hardware.Type}");
                    Console.WriteLine("Software Components: {0}",
                        hardware.softwareNames().Count > 0 ? string.Join(", ", hardware.softwareNames()) : "None");
                }

            }
        }

        private static void Analyze(Dictionary<string, Hardware> mapNameHardware)
        {
            int coutHardware = mapNameHardware.Count;
            int countSoftware = countTotalSoftware(mapNameHardware);

            int memoryInUse = CalcTotalInUseMem(mapNameHardware);
            int capacityInUse = CalcTotalInUseCapacity(mapNameHardware);
            int totalMemory = CalcTotalMemory(mapNameHardware);
            int totalCapacity = CalcTotalCapacity(mapNameHardware);

            Console.WriteLine("System Analysis");
            Console.WriteLine($"Hardware Components: {coutHardware}");
            Console.WriteLine($"Software Components: {countSoftware}");
            Console.WriteLine($"Total Operational Memory: {memoryInUse} / {totalMemory}");
            Console.WriteLine($"Total Capacity Taken: {capacityInUse} / {totalCapacity}"); 
        }

        private static int CalcTotalInUseMem(Dictionary<string, Hardware> mapNameHardware)
        {
            int result = 0;
            foreach (var hardware in mapNameHardware.Values)
            {
                result += hardware.CalcMemoryConsumption();
            }
            return result;
        }

        private static int CalcTotalInUseCapacity(Dictionary<string, Hardware> mapNameHardware)
        {
            int result = 0;
            foreach (var hardware in mapNameHardware.Values)
            {
                result += hardware.CalcCapacityConsumption();
            }
            return result;
        }

        private static int countTotalSoftware(Dictionary<string, Hardware> mapNameHardware)
        {
            int result = 0;
            foreach (var hardware in mapNameHardware.Values)
            {
                result += hardware.MapNameSoftware.Count;
            }
            return result;
        }

        private static void ReleaseSoftwareComponent(Dictionary<string, Hardware> mapNameHardware, string parameters)
        {
            string[] tokens = parameters.Split(',');
            string hardwareName = tokens[0].Trim();
            string softwareName = tokens[1].Remove(tokens[1].Length - 1, 1).Trim();

            if (!mapNameHardware.ContainsKey(hardwareName) 
                || !mapNameHardware[hardwareName].MapNameSoftware.ContainsKey(softwareName))
            {
                return;
            }

            mapNameHardware[hardwareName].MapNameSoftware.Remove(softwareName);

        }

        public static int CalcTotalMemory(Dictionary<string, Hardware> mapNameHardware)
        {
            int result = 0;
            foreach (var hardware in mapNameHardware.Values)
            {
                result += hardware.MaxMemory;
            }
            return result;
        }

        public static int CalcTotalCapacity(Dictionary<string, Hardware> mapNameHardware)
        {
            int result = 0;
            foreach (var hardware in mapNameHardware.Values)
            {
                result += hardware.MaxCapacity;
            }
            return result;
        }

        private static void RegisterExpressSoftware(Dictionary<string, Hardware> mapNameHardware, string parameters)
        {
            string[] tokens = parameters.Split(',');
            string hardwareName = tokens[0].Trim();
            string softwareName = tokens[1].Trim();
            int capacity = int.Parse(tokens[2].Trim());
            int memory = int.Parse(tokens[3].Remove(tokens[3].Length - 1,1).Trim());
            
            if (!mapNameHardware.ContainsKey(hardwareName))
            {
                return;
            }

            int memConsumption = mapNameHardware[hardwareName].CalcMemoryConsumption();
            int totalMem = mapNameHardware[hardwareName].MaxMemory;
            int freeMem = totalMem - memConsumption;

            int capacityConsumption = mapNameHardware[hardwareName].CalcCapacityConsumption();
            int totalCapacity = mapNameHardware[hardwareName].MaxCapacity;
            int freeCapacity = totalCapacity - capacityConsumption;

            Software expessSoftware = new ExpressSoftware(softwareName, capacity, memory);

            if (freeMem < expessSoftware.MemoryConsumption || freeCapacity < expessSoftware.CapacityConsumption)
            {
                return;
            }
            
            mapNameHardware[hardwareName].MapNameSoftware.Add(softwareName,expessSoftware);

        }

        private static void RegisterLightSoftware(Dictionary<string, Hardware> mapNameHardware, string parameters)
        {
            string[] tokens = parameters.Split(',');
            string hardwareName = tokens[0].Trim();
            string softwareName = tokens[1].Trim();
            int capacity = int.Parse(tokens[2].Trim());
            int memory = int.Parse(tokens[3].Remove(tokens[3].Length - 1, 1).Trim());

            if (!mapNameHardware.ContainsKey(hardwareName))
            {
                return;
            }

            int memConsumption = mapNameHardware[hardwareName].CalcMemoryConsumption();
            int totalMem = mapNameHardware[hardwareName].MaxMemory;
            int freeMem = totalMem - memConsumption;

            int capacityConsumption = mapNameHardware[hardwareName].CalcCapacityConsumption();
            int totalCapacity = mapNameHardware[hardwareName].MaxCapacity;
            int freeCapacity = totalCapacity - capacityConsumption;

            Software lightSoftware = new LightSoftware(softwareName, capacity, memory);

            if (freeMem < lightSoftware.MemoryConsumption || freeCapacity < lightSoftware.CapacityConsumption)
            {
                return;
            }

            mapNameHardware[hardwareName].MapNameSoftware.Add(softwareName, lightSoftware);

        }

        private static void RegisterPowerHardware(Dictionary<string, Hardware> mapNameHardware,string parameters)
        {
            string[] tokens = parameters.Split(',');
            string name = tokens[0].Trim();
            int capacyty = int.Parse(tokens[1].Trim());
            int memory = int.Parse(tokens[2].Remove(tokens[2].Length - 1,1).Trim());

            Hardware powerHardware = new PowerHardware(name, capacyty, memory);
            mapNameHardware.Add(name, powerHardware);
            
        }

        private static void RegisterHeavyHardware(Dictionary<string, Hardware> mapNameHardware, string parameters)
        {
            string[] tokens = parameters.Split(',');
            string name = tokens[0].Trim();
            int capacyty = int.Parse(tokens[1].Trim());
            int memory = int.Parse(tokens[2].Remove(tokens[2].Length - 1, 1).Trim());          

            Hardware heavyHardware = new HeavyHardware(name, capacyty, memory);
            mapNameHardware.Add(name, heavyHardware);
        }
    }
}
