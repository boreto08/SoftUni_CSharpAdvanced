using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        IList<Birthable> listOfBirthables = new List<Birthable>();

        string input;

        while ((input = Console.ReadLine()) != "End") 
        {
            string[] args = input.Split(' ');
            string citizenType = args[0];

            switch (citizenType)
            {
                case "Citizen":
                    string name = args[1];
                    int age = int.Parse(args[2]);
                    string id = args[3];
                    string birthday = args[4];
                    listOfBirthables.Add(new Citizen(name, age, id, birthday));
                    break;
                case "Pet":
                    name = args[1];
                    birthday = args[2];
                    listOfBirthables.Add(new Pet(name, birthday));
                    break;
            }
        }

        string specificYear = Console.ReadLine();

        foreach (var citizen in listOfBirthables)
        {
            if (citizen.Birthday.EndsWith(specificYear))
            {
                Console.WriteLine(citizen.Birthday);
            }
        }
    }
}

