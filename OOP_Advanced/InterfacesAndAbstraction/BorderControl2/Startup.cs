
using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var listOfCitizens = new List<Identifiable>();

        string input;

        while ((input = Console.ReadLine())  != "End")
        {
            string[] args = input.Split(' ');
            if (args.Length == 3)
            {
                string name = args[0];
                int age = int.Parse(args[1]);
                string id = args[2];
                listOfCitizens.Add(new Citizen(name, age, id));
            }
            else
            {
                string model = args[0];
                string id = args[1];
                listOfCitizens.Add(new Robot(model, id));
            }
        }

        string strNum = Console.ReadLine();

        PrintFakes(listOfCitizens,strNum);
    }

    private static void PrintFakes(IEnumerable<Identifiable> listOfCitizens, string strNum)
    {
        foreach (var citizen in listOfCitizens)
        {
            if (citizen.Id.EndsWith(strNum))
            {
                Console.WriteLine(citizen.Id);
            }
        }
    }
}

