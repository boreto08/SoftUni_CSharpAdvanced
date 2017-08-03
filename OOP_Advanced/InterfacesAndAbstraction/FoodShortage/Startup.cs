using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        IDictionary<string,IBuyer> dicOfBuyers = new Dictionary<string,IBuyer>();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string[] args = Console.ReadLine().Split(' ');
            if (args.Length == 4)
            {
                string nameCitizen = args[0];
                int age = int.Parse(args[1]);
                string id = args[2];
                string birthday = args[3];
                dicOfBuyers.Add(nameCitizen, new Citizen(nameCitizen, age, id, birthday));
            }
            else if (args.Length == 3)
            {
                string nameRebel = args[0];
                dicOfBuyers.Add(nameRebel, new Rebel());
            }
        }

        string name;

        while ((name = Console.ReadLine()) !=  "End")
        {
            if (dicOfBuyers.ContainsKey(name))
            {
                dicOfBuyers[name].BuyFood();
            }
        }

        Console.WriteLine(dicOfBuyers.Values.Sum(b => b.Food));
    }
}

