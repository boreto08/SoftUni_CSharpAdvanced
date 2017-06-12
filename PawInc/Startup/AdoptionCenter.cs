namespace Startup
{
    using System.Collections.Generic;

    public class AdoptionCenter : Center
    {
        public AdoptionCenter(string name) 
            : base(name)
        {
        }


        public List<Animal> SendForCleansing()
        {
            List<Animal> result = new List<Animal>();
            List<Animal> cleanAnimals = new List<Animal>();
            foreach (var animal in this.Animals)
            {
                if (!animal.IsCleansed)
                {
                    result.Add(animal);
                }
                else
                {
                    cleanAnimals.Add(animal);
                }
            }
            this.Animals = cleanAnimals;
            return result;
        }

        public List<Animal> Adopt()
        {
            List<Animal> result = new List<Animal>();
            List<Animal> adoptedAnimals = new List<Animal>();
            foreach (var animal in Animals)
            {
                if (!animal.IsCleansed)
                {
                    result.Add(animal);
                }
                else
                {
                    adoptedAnimals.Add(animal);
                }
            }
   
            this.Animals = result;

            return adoptedAnimals;
        }
    }
}
