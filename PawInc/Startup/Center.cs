
using System.Collections.Generic;

namespace Startup
{
    public abstract class Center
    {
        private string name;
        private List<Animal> animals;

        protected Center(string name)
        {
            this.name = name;
            animals = new List<Animal>();
        }

 

        public List<Animal> Animals
        {
            get { return this.animals; }
            set { this.animals = value; }
        }

    }
}
