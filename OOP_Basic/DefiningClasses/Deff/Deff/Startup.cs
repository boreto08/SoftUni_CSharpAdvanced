namespace Deff

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  class Startup
    {
        public static void Main()
        {
            List<Person> listOfPersons = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person currPerson = new Person(name, age);
                listOfPersons.Add(currPerson);
            }

            listOfPersons
                .Where(p => p.age > 30)
                .OrderBy(p => p.name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
        }
    }
}
