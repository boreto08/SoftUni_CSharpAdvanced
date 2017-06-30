namespace CompanyRoster_04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            //Yovcho 610.13 Manager Sales
            var mapNameListEmpoyee = new Dictionary<string, List<Employee>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string position = tokens[2];
                string department = tokens[3];

                Employee currEmploee;

                if (tokens.Length == 4)
                {
                    currEmploee = new Employee(name, salary, position, department);
                }
                else if (tokens.Length == 5)
                {
                    try
                    {
                        int age = int.Parse(tokens[4]);
                        currEmploee = new Employee(name, salary, position, department, age);
                    }
                    catch (Exception)
                    {
                        string email = tokens[4];
                        currEmploee = new Employee(name, salary, position, department, email);
                        
                    }
                }
                else
                {
                    string email = tokens[4];
                    int age = int.Parse(tokens[5]);
                    currEmploee = new Employee(name, salary, position, department, email, age);
                }
                if (!mapNameListEmpoyee.ContainsKey(department))
                {
                    mapNameListEmpoyee.Add(department, new List<Employee>());
                }

                mapNameListEmpoyee[department].Add(currEmploee);
            }

            var list = mapNameListEmpoyee
               .OrderByDescending(e => e.Value.Average(x => x.Salary))
               .Take(1);

           
            foreach (var e in list)
            {
                Console.WriteLine($"Highest Average Salary: {e.Key}");
                foreach (var empl in e.Value.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{empl.Name} {empl.Salary:f2} {empl.Email} {empl.Age}");
                }
            }
            
        }
    }
}
