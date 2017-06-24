using System;
using System.Collections.Generic;
using System.Linq;

class CubicAssault
{
    static void Main()
    {
        var mapNameRegion = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Count em all")
            {
                break;
            }

            string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string nameRegion = tokens[0];
            string color = tokens[1];
            long amount = long.Parse(tokens[2]);

            if (!mapNameRegion.ContainsKey(nameRegion))
            {
                mapNameRegion.Add(nameRegion, new Dictionary<string, long>());

                mapNameRegion[nameRegion]["Green"] = 0;
                mapNameRegion[nameRegion]["Red"] = 0;
                mapNameRegion[nameRegion]["Black"] = 0;

                switch (color)
                {
                    case "Green":
                        mapNameRegion[nameRegion][color] += amount;
                        break;
                    case "Red":
                        mapNameRegion[nameRegion][color] += amount;
                        break;
                    case "Black":
                        mapNameRegion[nameRegion][color] += amount;
                        break;
                }

                TransformeMeteors(mapNameRegion, nameRegion);
            }
            else
            {              
                mapNameRegion[nameRegion][color] += amount;
                TransformeMeteors(mapNameRegion, nameRegion);
            }
        }

        var orderedMap = mapNameRegion
            .OrderByDescending(x => x.Value["Black"])
            .ThenBy(x => x.Key.Length)
            .ThenBy(x => x.Key);

        foreach (var region in orderedMap)
        {
            Console.WriteLine(region.Key);
            foreach (var colorAmount in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"-> {colorAmount.Key} : {colorAmount.Value}");
            }
        }

    }

    public static void TransformeMeteors(Dictionary<string, Dictionary<string, long>> mapNameRegion,string region)
    {
        while (mapNameRegion[region]["Green"] >= 1000000)
        {
            mapNameRegion[region]["Green"] -= 1000000;
            mapNameRegion[region]["Red"] += 1;
        }

        while (mapNameRegion[region]["Red"] >= 1000000)
        {
            mapNameRegion[region]["Red"] -= 1000000;
            mapNameRegion[region]["Black"] += 1;
        }
    }
}

