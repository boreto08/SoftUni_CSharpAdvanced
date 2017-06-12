namespace Startup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()

        {
            var mapNameAdoptionCenter = new Dictionary<string, AdoptionCenter>();
            var mapNameClensingCenter = new Dictionary<string, CleansingCenter>();

            var allCleanAnimls = new List<string>();
            var allAdoptedAnimls = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Paw Paw Pawah")
                {
                    break;
                }

                string[] tokens = input.Split('|');
                string command = tokens[0].Trim();

                switch (command)
                {
                    case "RegisterAdoptionCenter":
                        string adoptionCenterName = tokens[1].Trim();
                        RegisterAdoptionCenter(adoptionCenterName, mapNameAdoptionCenter);
                        break;
                    case "RegisterCleansingCenter":
                        string cleansingCenterName = tokens[1].Trim();
                        RegisterCleansingCenter(cleansingCenterName, mapNameClensingCenter);
                        break;
                    case "RegisterDog":
                        string nameDog = tokens[1].Trim();
                        int age = int.Parse(tokens[2].Trim());
                        int learnedCommands = int.Parse(tokens[3].Trim());
                        string nameAdoptionCenter = tokens[4].Trim();
                        RegisterDog(nameDog, age, learnedCommands, nameAdoptionCenter, mapNameAdoptionCenter);
                        break;
                    case "RegisterCat":
                        string nameCat = tokens[1].Trim();
                        int ageCat = int.Parse(tokens[2].Trim());
                        int IQ = int.Parse(tokens[3].Trim());
                        nameAdoptionCenter = tokens[4].Trim();
                        RegisterCat(nameCat, ageCat, IQ, nameAdoptionCenter, mapNameAdoptionCenter);
                        break;
                    case "SendForCleansing":
                        adoptionCenterName = tokens[1].Trim();
                        cleansingCenterName = tokens[2].Trim();
                        SendForCleansing(adoptionCenterName, cleansingCenterName,
                            mapNameAdoptionCenter, mapNameClensingCenter);
                        break;
                    case "Cleanse":
                        cleansingCenterName = tokens[1].Trim();
                        Cleanse(cleansingCenterName, mapNameClensingCenter, mapNameAdoptionCenter, allCleanAnimls);
                        break;
                    case "Adopt":
                        adoptionCenterName = tokens[1].Trim();
                        Adopt(adoptionCenterName, mapNameAdoptionCenter, allAdoptedAnimls);
                        break;
                }
            }

            Console.WriteLine("Paw Incorporative Regular Statistics");
            Console.WriteLine("Adoption Centers: {0}",mapNameAdoptionCenter.Count);
            Console.WriteLine("Cleansing Centers: {0}",mapNameClensingCenter.Count);
            Console.WriteLine("Adopted Animals: {0}",allAdoptedAnimls.Count == 0 ? "None" : string.Join(", ",allAdoptedAnimls.OrderBy(n => n)));
            Console.WriteLine("Cleansed Animals: {0}", allCleanAnimls.Count == 0 ? "None" :  string.Join(", ", allCleanAnimls.OrderBy(n => n)));

            int animalsAwaitiongAdoption = 0;
            foreach (var center in mapNameAdoptionCenter.Values)
            {
                if (center.Animals.Count > 0)
                { 
                    foreach (var animal in center.Animals)
                    {
                        if (animal.IsCleansed)
                        {
                            animalsAwaitiongAdoption++;
                        }
                    }
                }
            }
            int animalsAwaitiongCleaning = 0;
            foreach (var animal in mapNameClensingCenter.Values)
            {
                if (animal.Animals.Count > 0)
                {
                    
                    animalsAwaitiongCleaning += animal.Animals.Count;
                }            
            }

            Console.WriteLine("Animals Awaiting Adoption: {0}",animalsAwaitiongAdoption);
            Console.WriteLine("Animals Awaiting Cleansing: {0}", animalsAwaitiongCleaning);

        }

        private static void Adopt(string adoptionCenterName,
            Dictionary<string, AdoptionCenter> mapNameAdoptionCenter
            , List<string> allAdoptedAnimals)
        {
            List<Animal> adoptedAnimals = mapNameAdoptionCenter[adoptionCenterName].Adopt();
            foreach (var animal in adoptedAnimals)
            {
                allAdoptedAnimals.Add(animal.Name);
            }
        }

        private static void Cleanse(string cleansingCenterName,
            Dictionary<string, CleansingCenter> mapNameClensingCenter,
            Dictionary<string, AdoptionCenter> mapNameAdoptionCenter, List<string> allCleanAnimals)
        {
            Stack<Animal> cleanedAnimals = mapNameClensingCenter[cleansingCenterName].CleanAllAnimals();

            while (cleanedAnimals.Count > 0)
            {
                Animal currentAnimal = cleanedAnimals.Pop();

                allCleanAnimals.Add(currentAnimal.Name);

                string nameAdoptionCenter = currentAnimal.AdoptionCenter;
                mapNameAdoptionCenter[nameAdoptionCenter].Animals.Add(currentAnimal);
            }
        }

        private static void SendForCleansing(string adoptionCenterName, string cleansingCenterName,
            Dictionary<string, AdoptionCenter> mapNameAdoptionCenter, Dictionary<string, CleansingCenter> mapNameClensingCenter)
        {
            List<Animal> animalsToClean = mapNameAdoptionCenter[adoptionCenterName].SendForCleansing();
            mapNameClensingCenter[cleansingCenterName].AddAnimals(animalsToClean);
        }

        private static void RegisterCat(string nameCat, int ageCat, int iQ,
            string nameAdoptionCenter, Dictionary<string, AdoptionCenter> mapNameAdoptionCenter)
        {
            Animal currCat = new Cat(nameCat, ageCat, nameAdoptionCenter, iQ);
            if (mapNameAdoptionCenter.ContainsKey(nameAdoptionCenter))
            {
                mapNameAdoptionCenter[nameAdoptionCenter].Animals.Add(currCat);
            }
        }

        private static void RegisterDog(string nameDog, int age, int learnedCommands,
            string nameAdoptionCenter, Dictionary<string, AdoptionCenter> mapNameAdoptionCenter)
        {
            //here can be dog not animal same for other register methods (check them to be sure)
            Animal currDog = new Dog(nameDog, age, nameAdoptionCenter, learnedCommands);
            if (mapNameAdoptionCenter.ContainsKey(nameAdoptionCenter))
            {
                mapNameAdoptionCenter[nameAdoptionCenter].Animals.Add(currDog);
            }
        }

        private static void RegisterCleansingCenter(string cleansingCenterName, Dictionary<string, CleansingCenter> mapNameClensingCenter)
        {
            if (!mapNameClensingCenter.ContainsKey(cleansingCenterName))
            {
                CleansingCenter clensingCenter = new CleansingCenter(cleansingCenterName);
                mapNameClensingCenter.Add(cleansingCenterName, clensingCenter);
            }
        }

        private static void RegisterAdoptionCenter(string adoptionCenterName, Dictionary<string, AdoptionCenter> mapNameAdoptionCenter)
        {
            if (!mapNameAdoptionCenter.ContainsKey(adoptionCenterName))
            {
                AdoptionCenter newAdoptionCenter = new AdoptionCenter(adoptionCenterName);
                mapNameAdoptionCenter.Add(adoptionCenterName, newAdoptionCenter);
            }
        }
    }
}
