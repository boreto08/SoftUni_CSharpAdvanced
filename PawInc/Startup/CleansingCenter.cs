using System.Collections.Generic;
namespace Startup
{
    public class CleansingCenter : Center
    {

        public CleansingCenter(string name)
            : base(name)
        {
        }

        public void AddAnimals(List<Animal> animalsToClean)
        {
            foreach (var animal in animalsToClean)
            {
                this.Animals.Add(animal);
            }
        }

        public Stack<Animal> CleanAllAnimals()
        {
            foreach (var animal in this.Animals)
            {
                animal.IsCleansed = true;
            }

            Stack<Animal> result = new Stack<Animal>();
            foreach (var animal in this.Animals)
            {
                result.Push(animal);
            }
            this.Animals = new List<Animal>();
            return result;
        }
    }
}
